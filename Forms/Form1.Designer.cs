
namespace Forms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fLIGHTNUMBERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dAYOFWEEKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aIRLINEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tAILNUMBERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRIGINAIRPORTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESTINATIONAIRPORTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sCHEDULEDDEPARTUREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dEPARTURETIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dEPARTUREDELAYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tAXIOUTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wHEELSOFFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sCHEDULEDTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eLAPSEDTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aIRTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dISTANCEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wHEELSONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tAXIINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sCHEDULEDARRIVALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aRRIVALTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aRRIVALDELAYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airport = new Forms.Airport();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middlenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofbirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mofifieddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.fLIGHTDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.origincountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationcountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.airlinenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vTripBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airport_DBDataSet = new Forms.Airport_DBDataSet();
            this.vEmergencyFlightsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vPersonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vEmergencyFlightsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vEmergencyFlightsTableAdapter = new Forms.Airport_DBDataSetTableAdapters.vEmergencyFlightsTableAdapter();
            this.vPersonTableAdapter = new Forms.Airport_DBDataSetTableAdapters.vPersonTableAdapter();
            this.vTripTableAdapter = new Forms.Airport_DBDataSetTableAdapters.vTripTableAdapter();
            this.flightTableAdapter = new Forms.AirportTableAdapters.FlightTableAdapter();
            this.personTableAdapter = new Forms.AirportTableAdapters.PersonTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airport)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vTripBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airport_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEmergencyFlightsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPersonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEmergencyFlightsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(981, 533);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(973, 504);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Flight";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fLIGHTNUMBERDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dAYOFWEEKDataGridViewTextBoxColumn,
            this.aIRLINEDataGridViewTextBoxColumn,
            this.tAILNUMBERDataGridViewTextBoxColumn,
            this.oRIGINAIRPORTDataGridViewTextBoxColumn,
            this.dESTINATIONAIRPORTDataGridViewTextBoxColumn,
            this.sCHEDULEDDEPARTUREDataGridViewTextBoxColumn,
            this.dEPARTURETIMEDataGridViewTextBoxColumn,
            this.dEPARTUREDELAYDataGridViewTextBoxColumn,
            this.tAXIOUTDataGridViewTextBoxColumn,
            this.wHEELSOFFDataGridViewTextBoxColumn,
            this.sCHEDULEDTIMEDataGridViewTextBoxColumn,
            this.eLAPSEDTIMEDataGridViewTextBoxColumn,
            this.aIRTIMEDataGridViewTextBoxColumn,
            this.dISTANCEDataGridViewTextBoxColumn,
            this.wHEELSONDataGridViewTextBoxColumn,
            this.tAXIINDataGridViewTextBoxColumn,
            this.sCHEDULEDARRIVALDataGridViewTextBoxColumn,
            this.aRRIVALTIMEDataGridViewTextBoxColumn,
            this.aRRIVALDELAYDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.flightBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(960, 491);
            this.dataGridView1.TabIndex = 0;
            // 
            // fLIGHTNUMBERDataGridViewTextBoxColumn
            // 
            this.fLIGHTNUMBERDataGridViewTextBoxColumn.DataPropertyName = "FLIGHT_NUMBER";
            this.fLIGHTNUMBERDataGridViewTextBoxColumn.HeaderText = "FLIGHT_NUMBER";
            this.fLIGHTNUMBERDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fLIGHTNUMBERDataGridViewTextBoxColumn.Name = "fLIGHTNUMBERDataGridViewTextBoxColumn";
            this.fLIGHTNUMBERDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "YEAR";
            this.dataGridViewTextBoxColumn1.HeaderText = "YEAR";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MONTH";
            this.dataGridViewTextBoxColumn2.HeaderText = "MONTH";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DAY";
            this.dataGridViewTextBoxColumn3.HeaderText = "DAY";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dAYOFWEEKDataGridViewTextBoxColumn
            // 
            this.dAYOFWEEKDataGridViewTextBoxColumn.DataPropertyName = "DAY_OF_WEEK";
            this.dAYOFWEEKDataGridViewTextBoxColumn.HeaderText = "DAY_OF_WEEK";
            this.dAYOFWEEKDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dAYOFWEEKDataGridViewTextBoxColumn.Name = "dAYOFWEEKDataGridViewTextBoxColumn";
            this.dAYOFWEEKDataGridViewTextBoxColumn.Width = 125;
            // 
            // aIRLINEDataGridViewTextBoxColumn
            // 
            this.aIRLINEDataGridViewTextBoxColumn.DataPropertyName = "AIRLINE";
            this.aIRLINEDataGridViewTextBoxColumn.HeaderText = "AIRLINE";
            this.aIRLINEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aIRLINEDataGridViewTextBoxColumn.Name = "aIRLINEDataGridViewTextBoxColumn";
            this.aIRLINEDataGridViewTextBoxColumn.Width = 125;
            // 
            // tAILNUMBERDataGridViewTextBoxColumn
            // 
            this.tAILNUMBERDataGridViewTextBoxColumn.DataPropertyName = "TAIL_NUMBER";
            this.tAILNUMBERDataGridViewTextBoxColumn.HeaderText = "TAIL_NUMBER";
            this.tAILNUMBERDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tAILNUMBERDataGridViewTextBoxColumn.Name = "tAILNUMBERDataGridViewTextBoxColumn";
            this.tAILNUMBERDataGridViewTextBoxColumn.Width = 125;
            // 
            // oRIGINAIRPORTDataGridViewTextBoxColumn
            // 
            this.oRIGINAIRPORTDataGridViewTextBoxColumn.DataPropertyName = "ORIGIN_AIRPORT";
            this.oRIGINAIRPORTDataGridViewTextBoxColumn.HeaderText = "ORIGIN_AIRPORT";
            this.oRIGINAIRPORTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oRIGINAIRPORTDataGridViewTextBoxColumn.Name = "oRIGINAIRPORTDataGridViewTextBoxColumn";
            this.oRIGINAIRPORTDataGridViewTextBoxColumn.Width = 125;
            // 
            // dESTINATIONAIRPORTDataGridViewTextBoxColumn
            // 
            this.dESTINATIONAIRPORTDataGridViewTextBoxColumn.DataPropertyName = "DESTINATION_AIRPORT";
            this.dESTINATIONAIRPORTDataGridViewTextBoxColumn.HeaderText = "DESTINATION_AIRPORT";
            this.dESTINATIONAIRPORTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dESTINATIONAIRPORTDataGridViewTextBoxColumn.Name = "dESTINATIONAIRPORTDataGridViewTextBoxColumn";
            this.dESTINATIONAIRPORTDataGridViewTextBoxColumn.Width = 125;
            // 
            // sCHEDULEDDEPARTUREDataGridViewTextBoxColumn
            // 
            this.sCHEDULEDDEPARTUREDataGridViewTextBoxColumn.DataPropertyName = "SCHEDULED_DEPARTURE";
            this.sCHEDULEDDEPARTUREDataGridViewTextBoxColumn.HeaderText = "SCHEDULED_DEPARTURE";
            this.sCHEDULEDDEPARTUREDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sCHEDULEDDEPARTUREDataGridViewTextBoxColumn.Name = "sCHEDULEDDEPARTUREDataGridViewTextBoxColumn";
            this.sCHEDULEDDEPARTUREDataGridViewTextBoxColumn.Width = 125;
            // 
            // dEPARTURETIMEDataGridViewTextBoxColumn
            // 
            this.dEPARTURETIMEDataGridViewTextBoxColumn.DataPropertyName = "DEPARTURE_TIME";
            this.dEPARTURETIMEDataGridViewTextBoxColumn.HeaderText = "DEPARTURE_TIME";
            this.dEPARTURETIMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dEPARTURETIMEDataGridViewTextBoxColumn.Name = "dEPARTURETIMEDataGridViewTextBoxColumn";
            this.dEPARTURETIMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // dEPARTUREDELAYDataGridViewTextBoxColumn
            // 
            this.dEPARTUREDELAYDataGridViewTextBoxColumn.DataPropertyName = "DEPARTURE_DELAY";
            this.dEPARTUREDELAYDataGridViewTextBoxColumn.HeaderText = "DEPARTURE_DELAY";
            this.dEPARTUREDELAYDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dEPARTUREDELAYDataGridViewTextBoxColumn.Name = "dEPARTUREDELAYDataGridViewTextBoxColumn";
            this.dEPARTUREDELAYDataGridViewTextBoxColumn.Width = 125;
            // 
            // tAXIOUTDataGridViewTextBoxColumn
            // 
            this.tAXIOUTDataGridViewTextBoxColumn.DataPropertyName = "TAXI_OUT";
            this.tAXIOUTDataGridViewTextBoxColumn.HeaderText = "TAXI_OUT";
            this.tAXIOUTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tAXIOUTDataGridViewTextBoxColumn.Name = "tAXIOUTDataGridViewTextBoxColumn";
            this.tAXIOUTDataGridViewTextBoxColumn.Width = 125;
            // 
            // wHEELSOFFDataGridViewTextBoxColumn
            // 
            this.wHEELSOFFDataGridViewTextBoxColumn.DataPropertyName = "WHEELS_OFF";
            this.wHEELSOFFDataGridViewTextBoxColumn.HeaderText = "WHEELS_OFF";
            this.wHEELSOFFDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.wHEELSOFFDataGridViewTextBoxColumn.Name = "wHEELSOFFDataGridViewTextBoxColumn";
            this.wHEELSOFFDataGridViewTextBoxColumn.Width = 125;
            // 
            // sCHEDULEDTIMEDataGridViewTextBoxColumn
            // 
            this.sCHEDULEDTIMEDataGridViewTextBoxColumn.DataPropertyName = "SCHEDULED_TIME";
            this.sCHEDULEDTIMEDataGridViewTextBoxColumn.HeaderText = "SCHEDULED_TIME";
            this.sCHEDULEDTIMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sCHEDULEDTIMEDataGridViewTextBoxColumn.Name = "sCHEDULEDTIMEDataGridViewTextBoxColumn";
            this.sCHEDULEDTIMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // eLAPSEDTIMEDataGridViewTextBoxColumn
            // 
            this.eLAPSEDTIMEDataGridViewTextBoxColumn.DataPropertyName = "ELAPSED_TIME";
            this.eLAPSEDTIMEDataGridViewTextBoxColumn.HeaderText = "ELAPSED_TIME";
            this.eLAPSEDTIMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eLAPSEDTIMEDataGridViewTextBoxColumn.Name = "eLAPSEDTIMEDataGridViewTextBoxColumn";
            this.eLAPSEDTIMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // aIRTIMEDataGridViewTextBoxColumn
            // 
            this.aIRTIMEDataGridViewTextBoxColumn.DataPropertyName = "AIR_TIME";
            this.aIRTIMEDataGridViewTextBoxColumn.HeaderText = "AIR_TIME";
            this.aIRTIMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aIRTIMEDataGridViewTextBoxColumn.Name = "aIRTIMEDataGridViewTextBoxColumn";
            this.aIRTIMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // dISTANCEDataGridViewTextBoxColumn
            // 
            this.dISTANCEDataGridViewTextBoxColumn.DataPropertyName = "DISTANCE";
            this.dISTANCEDataGridViewTextBoxColumn.HeaderText = "DISTANCE";
            this.dISTANCEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dISTANCEDataGridViewTextBoxColumn.Name = "dISTANCEDataGridViewTextBoxColumn";
            this.dISTANCEDataGridViewTextBoxColumn.Width = 125;
            // 
            // wHEELSONDataGridViewTextBoxColumn
            // 
            this.wHEELSONDataGridViewTextBoxColumn.DataPropertyName = "WHEELS_ON";
            this.wHEELSONDataGridViewTextBoxColumn.HeaderText = "WHEELS_ON";
            this.wHEELSONDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.wHEELSONDataGridViewTextBoxColumn.Name = "wHEELSONDataGridViewTextBoxColumn";
            this.wHEELSONDataGridViewTextBoxColumn.Width = 125;
            // 
            // tAXIINDataGridViewTextBoxColumn
            // 
            this.tAXIINDataGridViewTextBoxColumn.DataPropertyName = "TAXI_IN";
            this.tAXIINDataGridViewTextBoxColumn.HeaderText = "TAXI_IN";
            this.tAXIINDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tAXIINDataGridViewTextBoxColumn.Name = "tAXIINDataGridViewTextBoxColumn";
            this.tAXIINDataGridViewTextBoxColumn.Width = 125;
            // 
            // sCHEDULEDARRIVALDataGridViewTextBoxColumn
            // 
            this.sCHEDULEDARRIVALDataGridViewTextBoxColumn.DataPropertyName = "SCHEDULED_ARRIVAL";
            this.sCHEDULEDARRIVALDataGridViewTextBoxColumn.HeaderText = "SCHEDULED_ARRIVAL";
            this.sCHEDULEDARRIVALDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sCHEDULEDARRIVALDataGridViewTextBoxColumn.Name = "sCHEDULEDARRIVALDataGridViewTextBoxColumn";
            this.sCHEDULEDARRIVALDataGridViewTextBoxColumn.Width = 125;
            // 
            // aRRIVALTIMEDataGridViewTextBoxColumn
            // 
            this.aRRIVALTIMEDataGridViewTextBoxColumn.DataPropertyName = "ARRIVAL_TIME";
            this.aRRIVALTIMEDataGridViewTextBoxColumn.HeaderText = "ARRIVAL_TIME";
            this.aRRIVALTIMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aRRIVALTIMEDataGridViewTextBoxColumn.Name = "aRRIVALTIMEDataGridViewTextBoxColumn";
            this.aRRIVALTIMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // aRRIVALDELAYDataGridViewTextBoxColumn
            // 
            this.aRRIVALDELAYDataGridViewTextBoxColumn.DataPropertyName = "ARRIVAL_DELAY";
            this.aRRIVALDELAYDataGridViewTextBoxColumn.HeaderText = "ARRIVAL_DELAY";
            this.aRRIVALDELAYDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aRRIVALDELAYDataGridViewTextBoxColumn.Name = "aRRIVALDELAYDataGridViewTextBoxColumn";
            this.aRRIVALDELAYDataGridViewTextBoxColumn.Width = 125;
            // 
            // flightBindingSource
            // 
            this.flightBindingSource.DataMember = "Flight";
            this.flightBindingSource.DataSource = this.airport;
            // 
            // airport
            // 
            this.airport.DataSetName = "Airport";
            this.airport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(973, 504);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Person";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.middlenameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.dateofbirthDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.mofifieddateDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.personBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(7, 7);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(960, 491);
            this.dataGridView2.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "first_name";
            this.firstnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // middlenameDataGridViewTextBoxColumn
            // 
            this.middlenameDataGridViewTextBoxColumn.DataPropertyName = "middle_name";
            this.middlenameDataGridViewTextBoxColumn.HeaderText = "middle_name";
            this.middlenameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.middlenameDataGridViewTextBoxColumn.Name = "middlenameDataGridViewTextBoxColumn";
            this.middlenameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "last_name";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "last_name";
            this.lastnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateofbirthDataGridViewTextBoxColumn
            // 
            this.dateofbirthDataGridViewTextBoxColumn.DataPropertyName = "date_of_birth";
            this.dateofbirthDataGridViewTextBoxColumn.HeaderText = "date_of_birth";
            this.dateofbirthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateofbirthDataGridViewTextBoxColumn.Name = "dateofbirthDataGridViewTextBoxColumn";
            this.dateofbirthDataGridViewTextBoxColumn.Width = 125;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.Width = 125;
            // 
            // mofifieddateDataGridViewTextBoxColumn
            // 
            this.mofifieddateDataGridViewTextBoxColumn.DataPropertyName = "mofified_date";
            this.mofifieddateDataGridViewTextBoxColumn.HeaderText = "mofified_date";
            this.mofifieddateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mofifieddateDataGridViewTextBoxColumn.Name = "mofifieddateDataGridViewTextBoxColumn";
            this.mofifieddateDataGridViewTextBoxColumn.Width = 125;
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataMember = "Person";
            this.personBindingSource.DataSource = this.airport;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(973, 504);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Trip";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fLIGHTDATEDataGridViewTextBoxColumn,
            this.originnameDataGridViewTextBoxColumn,
            this.origincountryDataGridViewTextBoxColumn,
            this.destinationnameDataGridViewTextBoxColumn,
            this.destinationcountryDataGridViewTextBoxColumn,
            this.airlinenameDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.vTripBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(7, 7);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(960, 491);
            this.dataGridView3.TabIndex = 0;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // fLIGHTDATEDataGridViewTextBoxColumn
            // 
            this.fLIGHTDATEDataGridViewTextBoxColumn.DataPropertyName = "FLIGHT_DATE";
            this.fLIGHTDATEDataGridViewTextBoxColumn.HeaderText = "FLIGHT_DATE";
            this.fLIGHTDATEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fLIGHTDATEDataGridViewTextBoxColumn.Name = "fLIGHTDATEDataGridViewTextBoxColumn";
            this.fLIGHTDATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.fLIGHTDATEDataGridViewTextBoxColumn.Width = 125;
            // 
            // originnameDataGridViewTextBoxColumn
            // 
            this.originnameDataGridViewTextBoxColumn.DataPropertyName = "origin_name";
            this.originnameDataGridViewTextBoxColumn.HeaderText = "origin_name";
            this.originnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.originnameDataGridViewTextBoxColumn.Name = "originnameDataGridViewTextBoxColumn";
            this.originnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // origincountryDataGridViewTextBoxColumn
            // 
            this.origincountryDataGridViewTextBoxColumn.DataPropertyName = "origin_country";
            this.origincountryDataGridViewTextBoxColumn.HeaderText = "origin_country";
            this.origincountryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.origincountryDataGridViewTextBoxColumn.Name = "origincountryDataGridViewTextBoxColumn";
            this.origincountryDataGridViewTextBoxColumn.Width = 125;
            // 
            // destinationnameDataGridViewTextBoxColumn
            // 
            this.destinationnameDataGridViewTextBoxColumn.DataPropertyName = "destination_name";
            this.destinationnameDataGridViewTextBoxColumn.HeaderText = "destination_name";
            this.destinationnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.destinationnameDataGridViewTextBoxColumn.Name = "destinationnameDataGridViewTextBoxColumn";
            this.destinationnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // destinationcountryDataGridViewTextBoxColumn
            // 
            this.destinationcountryDataGridViewTextBoxColumn.DataPropertyName = "destination_country";
            this.destinationcountryDataGridViewTextBoxColumn.HeaderText = "destination_country";
            this.destinationcountryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.destinationcountryDataGridViewTextBoxColumn.Name = "destinationcountryDataGridViewTextBoxColumn";
            this.destinationcountryDataGridViewTextBoxColumn.Width = 125;
            // 
            // airlinenameDataGridViewTextBoxColumn
            // 
            this.airlinenameDataGridViewTextBoxColumn.DataPropertyName = "airline_name";
            this.airlinenameDataGridViewTextBoxColumn.HeaderText = "airline_name";
            this.airlinenameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.airlinenameDataGridViewTextBoxColumn.Name = "airlinenameDataGridViewTextBoxColumn";
            this.airlinenameDataGridViewTextBoxColumn.Width = 125;
            // 
            // vTripBindingSource
            // 
            this.vTripBindingSource.DataMember = "vTrip";
            this.vTripBindingSource.DataSource = this.airport_DBDataSet;
            // 
            // airport_DBDataSet
            // 
            this.airport_DBDataSet.DataSetName = "Airport_DBDataSet";
            this.airport_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vEmergencyFlightsBindingSource1
            // 
            this.vEmergencyFlightsBindingSource1.DataMember = "vEmergencyFlights";
            this.vEmergencyFlightsBindingSource1.DataSource = this.airport_DBDataSet;
            // 
            // vPersonBindingSource
            // 
            this.vPersonBindingSource.DataMember = "vPerson";
            this.vPersonBindingSource.DataSource = this.airport_DBDataSet;
            // 
            // vEmergencyFlightsBindingSource
            // 
            this.vEmergencyFlightsBindingSource.DataMember = "vEmergencyFlights";
            this.vEmergencyFlightsBindingSource.DataSource = this.airport_DBDataSet;
            // 
            // vEmergencyFlightsTableAdapter
            // 
            this.vEmergencyFlightsTableAdapter.ClearBeforeFill = true;
            // 
            // vPersonTableAdapter
            // 
            this.vPersonTableAdapter.ClearBeforeFill = true;
            // 
            // vTripTableAdapter
            // 
            this.vTripTableAdapter.ClearBeforeFill = true;
            // 
            // flightTableAdapter
            // 
            this.flightTableAdapter.ClearBeforeFill = true;
            // 
            // personTableAdapter
            // 
            this.personTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 558);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airport)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vTripBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airport_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEmergencyFlightsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPersonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEmergencyFlightsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Airport_DBDataSet airport_DBDataSet;
        private System.Windows.Forms.BindingSource vEmergencyFlightsBindingSource;
        private Airport_DBDataSetTableAdapters.vEmergencyFlightsTableAdapter vEmergencyFlightsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn yEARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mONTHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dAYDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vPersonBindingSource;
        private Airport_DBDataSetTableAdapters.vPersonTableAdapter vPersonTableAdapter;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource vTripBindingSource;
        private Airport_DBDataSetTableAdapters.vTripTableAdapter vTripTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fLIGHTDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn originnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn origincountryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationcountryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn airlinenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vEmergencyFlightsBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Airport airport;
        private System.Windows.Forms.BindingSource flightBindingSource;
        private AirportTableAdapters.FlightTableAdapter flightTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fLIGHTNUMBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dAYOFWEEKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aIRLINEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tAILNUMBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oRIGINAIRPORTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESTINATIONAIRPORTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCHEDULEDDEPARTUREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dEPARTURETIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dEPARTUREDELAYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tAXIOUTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wHEELSOFFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCHEDULEDTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eLAPSEDTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aIRTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dISTANCEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wHEELSONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tAXIINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCHEDULEDARRIVALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aRRIVALTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aRRIVALDELAYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource personBindingSource;
        private AirportTableAdapters.PersonTableAdapter personTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middlenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofbirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mofifieddateDataGridViewTextBoxColumn;
    }
}

