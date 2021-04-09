namespace TestDatenBank
{
    partial class Vertrag
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vertrag));
            System.Windows.Forms.Label vNummerLabel;
            System.Windows.Forms.Label ausleihDatumLabel;
            System.Windows.Forms.Label rueckgabeDatumLabel;
            System.Windows.Forms.Label kNummerLabel;
            System.Windows.Forms.Label mNummerLabel;
            this.testDatenBank2020DataSet = new TestDatenBank.TestDatenBank2020DataSet();
            this.vertragBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vertragTableAdapter = new TestDatenBank.TestDatenBank2020DataSetTableAdapters.VertragTableAdapter();
            this.tableAdapterManager = new TestDatenBank.TestDatenBank2020DataSetTableAdapters.TableAdapterManager();
            this.vertragBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.vertragBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.vNummerTextBox = new System.Windows.Forms.TextBox();
            this.ausleihDatumDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.rueckgabeDatumDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.kNummerTextBox = new System.Windows.Forms.TextBox();
            this.mNummerTextBox = new System.Windows.Forms.TextBox();
            vNummerLabel = new System.Windows.Forms.Label();
            ausleihDatumLabel = new System.Windows.Forms.Label();
            rueckgabeDatumLabel = new System.Windows.Forms.Label();
            kNummerLabel = new System.Windows.Forms.Label();
            mNummerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.testDatenBank2020DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vertragBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vertragBindingNavigator)).BeginInit();
            this.vertragBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // testDatenBank2020DataSet
            // 
            this.testDatenBank2020DataSet.DataSetName = "TestDatenBank2020DataSet";
            this.testDatenBank2020DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vertragBindingSource
            // 
            this.vertragBindingSource.DataMember = "Vertrag";
            this.vertragBindingSource.DataSource = this.testDatenBank2020DataSet;
            // 
            // vertragTableAdapter
            // 
            this.vertragTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KundeTableAdapter = null;
            this.tableAdapterManager.MediumTableAdapter = null;
            this.tableAdapterManager.ReservierungTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TestDatenBank.TestDatenBank2020DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VertragTableAdapter = this.vertragTableAdapter;
            // 
            // vertragBindingNavigator
            // 
            this.vertragBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.vertragBindingNavigator.BindingSource = this.vertragBindingSource;
            this.vertragBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.vertragBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.vertragBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.vertragBindingNavigatorSaveItem});
            this.vertragBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.vertragBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.vertragBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.vertragBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.vertragBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.vertragBindingNavigator.Name = "vertragBindingNavigator";
            this.vertragBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.vertragBindingNavigator.Size = new System.Drawing.Size(351, 25);
            this.vertragBindingNavigator.TabIndex = 0;
            this.vertragBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Erste verschieben";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Vorherige verschieben";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Aktuelle Position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(44, 15);
            this.bindingNavigatorCountItem.Text = "von {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Die Gesamtanzahl der Elemente.";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Nächste verschieben";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Letzte verschieben";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Neu hinzufügen";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Löschen";
            // 
            // vertragBindingNavigatorSaveItem
            // 
            this.vertragBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.vertragBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("vertragBindingNavigatorSaveItem.Image")));
            this.vertragBindingNavigatorSaveItem.Name = "vertragBindingNavigatorSaveItem";
            this.vertragBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.vertragBindingNavigatorSaveItem.Text = "Daten speichern";
            this.vertragBindingNavigatorSaveItem.Click += new System.EventHandler(this.vertragBindingNavigatorSaveItem_Click);
            // 
            // vNummerLabel
            // 
            vNummerLabel.AutoSize = true;
            vNummerLabel.Location = new System.Drawing.Point(12, 41);
            vNummerLabel.Name = "vNummerLabel";
            vNummerLabel.Size = new System.Drawing.Size(58, 13);
            vNummerLabel.TabIndex = 1;
            vNummerLabel.Text = "v Nummer:";
            // 
            // vNummerTextBox
            // 
            this.vNummerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vertragBindingSource, "vNummer", true));
            this.vNummerTextBox.Location = new System.Drawing.Point(113, 38);
            this.vNummerTextBox.Name = "vNummerTextBox";
            this.vNummerTextBox.Size = new System.Drawing.Size(200, 20);
            this.vNummerTextBox.TabIndex = 2;
            // 
            // ausleihDatumLabel
            // 
            ausleihDatumLabel.AutoSize = true;
            ausleihDatumLabel.Location = new System.Drawing.Point(12, 68);
            ausleihDatumLabel.Name = "ausleihDatumLabel";
            ausleihDatumLabel.Size = new System.Drawing.Size(77, 13);
            ausleihDatumLabel.TabIndex = 3;
            ausleihDatumLabel.Text = "ausleih Datum:";
            // 
            // ausleihDatumDateTimePicker
            // 
            this.ausleihDatumDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vertragBindingSource, "ausleihDatum", true));
            this.ausleihDatumDateTimePicker.Location = new System.Drawing.Point(113, 64);
            this.ausleihDatumDateTimePicker.Name = "ausleihDatumDateTimePicker";
            this.ausleihDatumDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.ausleihDatumDateTimePicker.TabIndex = 4;
            // 
            // rueckgabeDatumLabel
            // 
            rueckgabeDatumLabel.AutoSize = true;
            rueckgabeDatumLabel.Location = new System.Drawing.Point(12, 94);
            rueckgabeDatumLabel.Name = "rueckgabeDatumLabel";
            rueckgabeDatumLabel.Size = new System.Drawing.Size(95, 13);
            rueckgabeDatumLabel.TabIndex = 5;
            rueckgabeDatumLabel.Text = "rueckgabe Datum:";
            // 
            // rueckgabeDatumDateTimePicker
            // 
            this.rueckgabeDatumDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vertragBindingSource, "rueckgabeDatum", true));
            this.rueckgabeDatumDateTimePicker.Location = new System.Drawing.Point(113, 90);
            this.rueckgabeDatumDateTimePicker.Name = "rueckgabeDatumDateTimePicker";
            this.rueckgabeDatumDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.rueckgabeDatumDateTimePicker.TabIndex = 6;
            // 
            // kNummerLabel
            // 
            kNummerLabel.AutoSize = true;
            kNummerLabel.Location = new System.Drawing.Point(12, 119);
            kNummerLabel.Name = "kNummerLabel";
            kNummerLabel.Size = new System.Drawing.Size(58, 13);
            kNummerLabel.TabIndex = 7;
            kNummerLabel.Text = "k Nummer:";
            // 
            // kNummerTextBox
            // 
            this.kNummerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vertragBindingSource, "kNummer", true));
            this.kNummerTextBox.Location = new System.Drawing.Point(113, 116);
            this.kNummerTextBox.Name = "kNummerTextBox";
            this.kNummerTextBox.Size = new System.Drawing.Size(200, 20);
            this.kNummerTextBox.TabIndex = 8;
            // 
            // mNummerLabel
            // 
            mNummerLabel.AutoSize = true;
            mNummerLabel.Location = new System.Drawing.Point(12, 145);
            mNummerLabel.Name = "mNummerLabel";
            mNummerLabel.Size = new System.Drawing.Size(60, 13);
            mNummerLabel.TabIndex = 9;
            mNummerLabel.Text = "m Nummer:";
            // 
            // mNummerTextBox
            // 
            this.mNummerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vertragBindingSource, "mNummer", true));
            this.mNummerTextBox.Location = new System.Drawing.Point(113, 142);
            this.mNummerTextBox.Name = "mNummerTextBox";
            this.mNummerTextBox.Size = new System.Drawing.Size(200, 20);
            this.mNummerTextBox.TabIndex = 10;
            // 
            // Vertrag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 216);
            this.Controls.Add(vNummerLabel);
            this.Controls.Add(this.vNummerTextBox);
            this.Controls.Add(ausleihDatumLabel);
            this.Controls.Add(this.ausleihDatumDateTimePicker);
            this.Controls.Add(rueckgabeDatumLabel);
            this.Controls.Add(this.rueckgabeDatumDateTimePicker);
            this.Controls.Add(kNummerLabel);
            this.Controls.Add(this.kNummerTextBox);
            this.Controls.Add(mNummerLabel);
            this.Controls.Add(this.mNummerTextBox);
            this.Controls.Add(this.vertragBindingNavigator);
            this.Name = "Vertrag";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vertrag";
            this.Load += new System.EventHandler(this.Vertrag_Load);
            ((System.ComponentModel.ISupportInitialize)(this.testDatenBank2020DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vertragBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vertragBindingNavigator)).EndInit();
            this.vertragBindingNavigator.ResumeLayout(false);
            this.vertragBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TestDatenBank2020DataSet testDatenBank2020DataSet;
        private System.Windows.Forms.BindingSource vertragBindingSource;
        private TestDatenBank2020DataSetTableAdapters.VertragTableAdapter vertragTableAdapter;
        private TestDatenBank2020DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator vertragBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton vertragBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox vNummerTextBox;
        private System.Windows.Forms.DateTimePicker ausleihDatumDateTimePicker;
        private System.Windows.Forms.DateTimePicker rueckgabeDatumDateTimePicker;
        private System.Windows.Forms.TextBox kNummerTextBox;
        private System.Windows.Forms.TextBox mNummerTextBox;
    }
}