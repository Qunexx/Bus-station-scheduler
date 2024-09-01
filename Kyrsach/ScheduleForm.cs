using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace Kyrsach
{
    public partial class ScheduleForm : Form
    {
        private BindingList<BusTrip> busTrips;
        private BindingList<Stop> stops;
        private BusTrip selectedTrip;

        public ScheduleForm()
        {
            InitializeComponent();
            LoadStopsDataGridView();
            LoadTripsDatagridView();
        }


        private void LoadStopsDataGridView()
        {
            stops = new BindingList<Stop>();
            dataGridViewStops.AutoGenerateColumns = false;

            dataGridViewStops.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "StopName",
                HeaderText = "Название остановки"
            });
            dataGridViewStops.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DistanceFromStart",
                HeaderText = "Расстояние от начала маршрута (км)"
            });

            dataGridViewStops.DataSource = stops;
        }



        private void LoadTripsDatagridView()
        {
            dataGridView1.AutoGenerateColumns = false;


            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TripNumber",
                HeaderText = "Номер поездки"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "BusType",
                HeaderText = "Тип автобуса"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "RouteName",
                HeaderText = "Название маршрута"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DepartureTime",
                HeaderText = "Время отправления"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TravelTime",
                HeaderText = "Время в пути"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TotalSeats",
                HeaderText = "Общее количество мест"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FreeSeats",
                HeaderText = "Свободные места"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "BookedSeats",
                HeaderText = "Забронированные места"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "SoldSeats",
                HeaderText = "Проданные места"
            });
            busTrips = new BindingList<BusTrip>();
            dataGridView1.DataSource = busTrips;
        }




        private void SaveButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "XML Files (*.xml)|*.xml";
            saveFileDialog1.DefaultExt = "xml";
            saveFileDialog1.AddExtension = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    XMLClass.WriteToXmlFile(saveFileDialog1.FileName, busTrips);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при сохранении файла: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ReadFileButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "XML Files (*.xml)|*.xml";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    busTrips = XMLClass.ReadFromXmlFile<BindingList<BusTrip>>(openFileDialog1.FileName);
                    dataGridView1.DataSource = busTrips;
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show("Ошибка при чтении файла: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AddTripButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTripNumber.Text) ||
                string.IsNullOrWhiteSpace(txtBusType.Text) ||
                string.IsNullOrWhiteSpace(txtRouteName.Text) ||
                string.IsNullOrWhiteSpace(txtDestination.Text) ||
                string.IsNullOrWhiteSpace(txtTotalSeats.Text) ||
                string.IsNullOrWhiteSpace(txtFreeSeats.Text) ||
                string.IsNullOrWhiteSpace(txtBookedSeats.Text) ||
                string.IsNullOrWhiteSpace(txtSoldSeats.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля перед добавлением поездки.", "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newTrip = new BusTrip
            {
                TripNumber = txtTripNumber.Text,
                BusType = txtBusType.Text,
                Route = new BusRoute
                {
                    RouteName = txtRouteName.Text,
                    Destination = txtDestination.Text,
                    Stops = new List<Stop>(stops)
                },
                DepartureTime = dtpDepartureTime.Value,
                TravelHours = (int)numTravelHours.Value,
                TravelMinutes = (int)numTravelMinutes.Value,
                TotalSeats = int.Parse(txtTotalSeats.Text),
                FreeSeats = int.Parse(txtFreeSeats.Text),
                BookedSeats = int.Parse(txtBookedSeats.Text),
                SoldSeats = int.Parse(txtSoldSeats.Text)
            };

            busTrips.Add(newTrip);
        }

        private void DeleteTripButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var tripToDelete = dataGridView1.SelectedRows[0].DataBoundItem as BusTrip;
                if (tripToDelete != null)
                {
                    busTrips.Remove(tripToDelete);
                }
            }
        }

        private void AddStopButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStopName.Text) ||
                string.IsNullOrWhiteSpace(txtStopDistance.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля перед добавлением остановки.", "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtStopDistance.Text, out double distance))
            {
                MessageBox.Show("Пожалуйста, введите допустимое числовое значение для расстояния.", "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newStop = new Stop
            {
                StopName = txtStopName.Text,
                DistanceFromStart = distance
            };

            stops.Add(newStop);

            if (selectedTrip != null)
            {
                selectedTrip.Route.Stops = new List<Stop>(stops);
            }

            dataGridViewStops.DataSource = null;
            dataGridViewStops.DataSource = stops;
        }


        private void DeleteStopButton_Click(object sender, EventArgs e)
        {
            if (dataGridViewStops.SelectedRows.Count > 0)
            {
                var stopToDelete = dataGridViewStops.SelectedRows[0].DataBoundItem as Stop;
                if (stopToDelete != null)
                {
                    stops.Remove(stopToDelete);

                   
                    if (selectedTrip != null)
                    {
                        selectedTrip.Route.Stops = new List<Stop>(stops);
                    }

                    
                    dataGridViewStops.DataSource = null;
                    dataGridViewStops.DataSource = stops;
                }
            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                selectedTrip = dataGridView1.Rows[e.RowIndex].DataBoundItem as BusTrip;
                if (selectedTrip != null)
                {
                    txtTripNumber.Text = selectedTrip.TripNumber;
                    txtBusType.Text = selectedTrip.BusType;
                    txtRouteName.Text = selectedTrip.Route.RouteName;
                    txtDestination.Text = selectedTrip.Route.Destination;
                    dtpDepartureTime.Value = selectedTrip.DepartureTime;
                    numTravelHours.Value = selectedTrip.TravelTime.Hours;
                    numTravelMinutes.Value = selectedTrip.TravelTime.Minutes;
                    txtTotalSeats.Text = selectedTrip.TotalSeats.ToString();
                    txtFreeSeats.Text = selectedTrip.FreeSeats.ToString();
                    txtBookedSeats.Text = selectedTrip.BookedSeats.ToString();
                    txtSoldSeats.Text = selectedTrip.SoldSeats.ToString();

                   
                    stops.Clear();
                    foreach (var stop in selectedTrip.Route.Stops)
                    {
                        stops.Add(stop);
                    }

                   
                    dataGridViewStops.DataSource = null;
                    dataGridViewStops.DataSource = stops;
                }
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

       

    }
}