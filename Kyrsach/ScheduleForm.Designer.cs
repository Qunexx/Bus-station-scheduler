namespace Kyrsach
{
    partial class ScheduleForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewStops = new System.Windows.Forms.DataGridView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnAddTrip = new System.Windows.Forms.Button();
            this.btnDeleteTrip = new System.Windows.Forms.Button();
            this.txtTripNumber = new System.Windows.Forms.TextBox();
            this.txtBusType = new System.Windows.Forms.TextBox();
            this.txtRouteName = new System.Windows.Forms.TextBox();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.dtpDepartureTime = new System.Windows.Forms.DateTimePicker();
            this.numTravelHours = new System.Windows.Forms.NumericUpDown();
            this.numTravelMinutes = new System.Windows.Forms.NumericUpDown();
            this.txtTotalSeats = new System.Windows.Forms.TextBox();
            this.txtFreeSeats = new System.Windows.Forms.TextBox();
            this.txtBookedSeats = new System.Windows.Forms.TextBox();
            this.txtSoldSeats = new System.Windows.Forms.TextBox();
            this.txtStopName = new System.Windows.Forms.TextBox();
            this.txtStopDistance = new System.Windows.Forms.TextBox();
            this.btnAddStop = new System.Windows.Forms.Button();
            this.btnDeleteStop = new System.Windows.Forms.Button();
            this.lblTripNumber = new System.Windows.Forms.Label();
            this.lblBusType = new System.Windows.Forms.Label();
            this.lblRouteName = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.lblDepartureTime = new System.Windows.Forms.Label();
            this.lblTravelTime = new System.Windows.Forms.Label();
            this.lblTotalSeats = new System.Windows.Forms.Label();
            this.lblFreeSeats = new System.Windows.Forms.Label();
            this.lblBookedSeats = new System.Windows.Forms.Label();
            this.lblSoldSeats = new System.Windows.Forms.Label();
            this.lblStopName = new System.Windows.Forms.Label();
            this.lblStopDistance = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStops)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTravelHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTravelMinutes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 70);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(571, 261);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dataGridViewStops
            // 
            this.dataGridViewStops.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStops.Location = new System.Drawing.Point(15, 367);
            this.dataGridViewStops.MultiSelect = false;
            this.dataGridViewStops.Name = "dataGridViewStops";
            this.dataGridViewStops.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStops.Size = new System.Drawing.Size(515, 141);
            this.dataGridViewStops.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(647, 488);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 42);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Сохранить в XML";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(553, 488);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 42);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Загрузить из XML";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.ReadFileButton_Click);
            // 
            // btnAddTrip
            // 
            this.btnAddTrip.Location = new System.Drawing.Point(746, 355);
            this.btnAddTrip.Name = "btnAddTrip";
            this.btnAddTrip.Size = new System.Drawing.Size(86, 38);
            this.btnAddTrip.TabIndex = 4;
            this.btnAddTrip.Text = "Добавить рейс";
            this.btnAddTrip.UseVisualStyleBackColor = true;
            this.btnAddTrip.Click += new System.EventHandler(this.AddTripButton_Click);
            // 
            // btnDeleteTrip
            // 
            this.btnDeleteTrip.Location = new System.Drawing.Point(656, 355);
            this.btnDeleteTrip.Name = "btnDeleteTrip";
            this.btnDeleteTrip.Size = new System.Drawing.Size(77, 38);
            this.btnDeleteTrip.TabIndex = 5;
            this.btnDeleteTrip.Text = "Удалить рейс";
            this.btnDeleteTrip.UseVisualStyleBackColor = true;
            this.btnDeleteTrip.Click += new System.EventHandler(this.DeleteTripButton_Click);
            // 
            // txtTripNumber
            // 
            this.txtTripNumber.Location = new System.Drawing.Point(746, 70);
            this.txtTripNumber.Name = "txtTripNumber";
            this.txtTripNumber.Size = new System.Drawing.Size(100, 20);
            this.txtTripNumber.TabIndex = 6;
            // 
            // txtBusType
            // 
            this.txtBusType.Location = new System.Drawing.Point(746, 96);
            this.txtBusType.Name = "txtBusType";
            this.txtBusType.Size = new System.Drawing.Size(100, 20);
            this.txtBusType.TabIndex = 7;
            // 
            // txtRouteName
            // 
            this.txtRouteName.Location = new System.Drawing.Point(746, 122);
            this.txtRouteName.Name = "txtRouteName";
            this.txtRouteName.Size = new System.Drawing.Size(100, 20);
            this.txtRouteName.TabIndex = 8;
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(746, 148);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(100, 20);
            this.txtDestination.TabIndex = 9;
            // 
            // dtpDepartureTime
            // 
            this.dtpDepartureTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpDepartureTime.Location = new System.Drawing.Point(746, 174);
            this.dtpDepartureTime.Name = "dtpDepartureTime";
            this.dtpDepartureTime.Size = new System.Drawing.Size(100, 20);
            this.dtpDepartureTime.TabIndex = 10;
            // 
            // numTravelHours
            // 
            this.numTravelHours.Location = new System.Drawing.Point(760, 207);
            this.numTravelHours.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numTravelHours.Name = "numTravelHours";
            this.numTravelHours.Size = new System.Drawing.Size(40, 20);
            this.numTravelHours.TabIndex = 11;
            // 
            // numTravelMinutes
            // 
            this.numTravelMinutes.Location = new System.Drawing.Point(806, 207);
            this.numTravelMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numTravelMinutes.Name = "numTravelMinutes";
            this.numTravelMinutes.Size = new System.Drawing.Size(40, 20);
            this.numTravelMinutes.TabIndex = 12;
            // 
            // txtTotalSeats
            // 
            this.txtTotalSeats.Location = new System.Drawing.Point(760, 233);
            this.txtTotalSeats.Name = "txtTotalSeats";
            this.txtTotalSeats.Size = new System.Drawing.Size(100, 20);
            this.txtTotalSeats.TabIndex = 13;
            // 
            // txtFreeSeats
            // 
            this.txtFreeSeats.Location = new System.Drawing.Point(760, 259);
            this.txtFreeSeats.Name = "txtFreeSeats";
            this.txtFreeSeats.Size = new System.Drawing.Size(100, 20);
            this.txtFreeSeats.TabIndex = 14;
            // 
            // txtBookedSeats
            // 
            this.txtBookedSeats.Location = new System.Drawing.Point(760, 285);
            this.txtBookedSeats.Name = "txtBookedSeats";
            this.txtBookedSeats.Size = new System.Drawing.Size(100, 20);
            this.txtBookedSeats.TabIndex = 15;
            // 
            // txtSoldSeats
            // 
            this.txtSoldSeats.Location = new System.Drawing.Point(760, 311);
            this.txtSoldSeats.Name = "txtSoldSeats";
            this.txtSoldSeats.Size = new System.Drawing.Size(100, 20);
            this.txtSoldSeats.TabIndex = 16;
            // 
            // txtStopName
            // 
            this.txtStopName.Location = new System.Drawing.Point(153, 514);
            this.txtStopName.Name = "txtStopName";
            this.txtStopName.Size = new System.Drawing.Size(100, 20);
            this.txtStopName.TabIndex = 17;
            // 
            // txtStopDistance
            // 
            this.txtStopDistance.Location = new System.Drawing.Point(153, 536);
            this.txtStopDistance.Name = "txtStopDistance";
            this.txtStopDistance.Size = new System.Drawing.Size(100, 20);
            this.txtStopDistance.TabIndex = 18;
            // 
            // btnAddStop
            // 
            this.btnAddStop.Location = new System.Drawing.Point(270, 517);
            this.btnAddStop.Name = "btnAddStop";
            this.btnAddStop.Size = new System.Drawing.Size(88, 39);
            this.btnAddStop.TabIndex = 19;
            this.btnAddStop.Text = "Добавить остановку";
            this.btnAddStop.UseVisualStyleBackColor = true;
            this.btnAddStop.Click += new System.EventHandler(this.AddStopButton_Click);
            // 
            // btnDeleteStop
            // 
            this.btnDeleteStop.Location = new System.Drawing.Point(364, 517);
            this.btnDeleteStop.Name = "btnDeleteStop";
            this.btnDeleteStop.Size = new System.Drawing.Size(93, 39);
            this.btnDeleteStop.TabIndex = 20;
            this.btnDeleteStop.Text = "Удалить остановку";
            this.btnDeleteStop.UseVisualStyleBackColor = true;
            this.btnDeleteStop.Click += new System.EventHandler(this.DeleteStopButton_Click);
            // 
            // lblTripNumber
            // 
            this.lblTripNumber.AutoSize = true;
            this.lblTripNumber.Location = new System.Drawing.Point(623, 73);
            this.lblTripNumber.Name = "lblTripNumber";
            this.lblTripNumber.Size = new System.Drawing.Size(74, 13);
            this.lblTripNumber.TabIndex = 21;
            this.lblTripNumber.Text = "Номер рейса";
            // 
            // lblBusType
            // 
            this.lblBusType.AutoSize = true;
            this.lblBusType.Location = new System.Drawing.Point(623, 99);
            this.lblBusType.Name = "lblBusType";
            this.lblBusType.Size = new System.Drawing.Size(75, 13);
            this.lblBusType.TabIndex = 22;
            this.lblBusType.Text = "Тип автобуса";
            // 
            // lblRouteName
            // 
            this.lblRouteName.AutoSize = true;
            this.lblRouteName.Location = new System.Drawing.Point(623, 125);
            this.lblRouteName.Name = "lblRouteName";
            this.lblRouteName.Size = new System.Drawing.Size(110, 13);
            this.lblRouteName.TabIndex = 23;
            this.lblRouteName.Text = "Название маршрута";
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(623, 151);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(99, 13);
            this.lblDestination.TabIndex = 24;
            this.lblDestination.Text = "Пункт назначения";
            // 
            // lblDepartureTime
            // 
            this.lblDepartureTime.AutoSize = true;
            this.lblDepartureTime.Location = new System.Drawing.Point(623, 177);
            this.lblDepartureTime.Name = "lblDepartureTime";
            this.lblDepartureTime.Size = new System.Drawing.Size(108, 13);
            this.lblDepartureTime.TabIndex = 25;
            this.lblDepartureTime.Text = "Время отправления";
            // 
            // lblTravelTime
            // 
            this.lblTravelTime.AutoSize = true;
            this.lblTravelTime.Location = new System.Drawing.Point(623, 209);
            this.lblTravelTime.Name = "lblTravelTime";
            this.lblTravelTime.Size = new System.Drawing.Size(74, 13);
            this.lblTravelTime.TabIndex = 26;
            this.lblTravelTime.Text = "Время в пути";
            // 
            // lblTotalSeats
            // 
            this.lblTotalSeats.AutoSize = true;
            this.lblTotalSeats.Location = new System.Drawing.Point(623, 235);
            this.lblTotalSeats.Name = "lblTotalSeats";
            this.lblTotalSeats.Size = new System.Drawing.Size(131, 13);
            this.lblTotalSeats.TabIndex = 27;
            this.lblTotalSeats.Text = "Общее количество мест";
            // 
            // lblFreeSeats
            // 
            this.lblFreeSeats.AutoSize = true;
            this.lblFreeSeats.Location = new System.Drawing.Point(623, 261);
            this.lblFreeSeats.Name = "lblFreeSeats";
            this.lblFreeSeats.Size = new System.Drawing.Size(98, 13);
            this.lblFreeSeats.TabIndex = 28;
            this.lblFreeSeats.Text = "Свободные места";
            // 
            // lblBookedSeats
            // 
            this.lblBookedSeats.AutoSize = true;
            this.lblBookedSeats.Location = new System.Drawing.Point(623, 287);
            this.lblBookedSeats.Name = "lblBookedSeats";
            this.lblBookedSeats.Size = new System.Drawing.Size(134, 13);
            this.lblBookedSeats.TabIndex = 29;
            this.lblBookedSeats.Text = "Забронированные места";
            // 
            // lblSoldSeats
            // 
            this.lblSoldSeats.AutoSize = true;
            this.lblSoldSeats.Location = new System.Drawing.Point(623, 313);
            this.lblSoldSeats.Name = "lblSoldSeats";
            this.lblSoldSeats.Size = new System.Drawing.Size(99, 13);
            this.lblSoldSeats.TabIndex = 30;
            this.lblSoldSeats.Text = "Проданные места";
            // 
            // lblStopName
            // 
            this.lblStopName.AutoSize = true;
            this.lblStopName.Location = new System.Drawing.Point(12, 517);
            this.lblStopName.Name = "lblStopName";
            this.lblStopName.Size = new System.Drawing.Size(113, 13);
            this.lblStopName.TabIndex = 31;
            this.lblStopName.Text = "Название остановки";
            // 
            // lblStopDistance
            // 
            this.lblStopDistance.AutoSize = true;
            this.lblStopDistance.Location = new System.Drawing.Point(9, 539);
            this.lblStopDistance.Name = "lblStopDistance";
            this.lblStopDistance.Size = new System.Drawing.Size(138, 13);
            this.lblStopDistance.TabIndex = 32;
            this.lblStopDistance.Text = "Расстояние до остановки";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(787, 478);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 71);
            this.btnExit.TabIndex = 35;
            this.btnExit.Text = "Выход";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(588, 31);
            this.label1.TabIndex = 34;
            this.label1.Text = "Система управления расписанием автобусов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(11, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Остановки в выбранном рейсе";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(14, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Расписание рейсов";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 561);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblStopDistance);
            this.Controls.Add(this.lblStopName);
            this.Controls.Add(this.lblSoldSeats);
            this.Controls.Add(this.lblBookedSeats);
            this.Controls.Add(this.lblFreeSeats);
            this.Controls.Add(this.lblTotalSeats);
            this.Controls.Add(this.lblTravelTime);
            this.Controls.Add(this.lblDepartureTime);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.lblRouteName);
            this.Controls.Add(this.lblBusType);
            this.Controls.Add(this.lblTripNumber);
            this.Controls.Add(this.btnDeleteStop);
            this.Controls.Add(this.btnAddStop);
            this.Controls.Add(this.txtStopDistance);
            this.Controls.Add(this.txtStopName);
            this.Controls.Add(this.txtSoldSeats);
            this.Controls.Add(this.txtBookedSeats);
            this.Controls.Add(this.txtFreeSeats);
            this.Controls.Add(this.txtTotalSeats);
            this.Controls.Add(this.numTravelMinutes);
            this.Controls.Add(this.numTravelHours);
            this.Controls.Add(this.dtpDepartureTime);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.txtRouteName);
            this.Controls.Add(this.txtBusType);
            this.Controls.Add(this.txtTripNumber);
            this.Controls.Add(this.btnDeleteTrip);
            this.Controls.Add(this.btnAddTrip);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataGridViewStops);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Расписание автобусов";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStops)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTravelHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTravelMinutes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridViewStops;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnAddTrip;
        private System.Windows.Forms.Button btnDeleteTrip;
        private System.Windows.Forms.TextBox txtTripNumber;
        private System.Windows.Forms.TextBox txtBusType;
        private System.Windows.Forms.TextBox txtRouteName;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.DateTimePicker dtpDepartureTime;
        private System.Windows.Forms.NumericUpDown numTravelHours;
        private System.Windows.Forms.NumericUpDown numTravelMinutes;
        private System.Windows.Forms.TextBox txtTotalSeats;
        private System.Windows.Forms.TextBox txtFreeSeats;
        private System.Windows.Forms.TextBox txtBookedSeats;
        private System.Windows.Forms.TextBox txtSoldSeats;
        private System.Windows.Forms.TextBox txtStopName;
        private System.Windows.Forms.TextBox txtStopDistance;
        private System.Windows.Forms.Button btnAddStop;
        private System.Windows.Forms.Button btnDeleteStop;
        private System.Windows.Forms.Label lblTripNumber;
        private System.Windows.Forms.Label lblBusType;
        private System.Windows.Forms.Label lblRouteName;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label lblDepartureTime;
        private System.Windows.Forms.Label lblTravelTime;
        private System.Windows.Forms.Label lblTotalSeats;
        private System.Windows.Forms.Label lblFreeSeats;
        private System.Windows.Forms.Label lblBookedSeats;
        private System.Windows.Forms.Label lblSoldSeats;
        private System.Windows.Forms.Label lblStopName;
        private System.Windows.Forms.Label lblStopDistance;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
