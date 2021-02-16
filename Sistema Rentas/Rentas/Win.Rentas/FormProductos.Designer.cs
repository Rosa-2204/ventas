namespace Win.Rentas
{
    partial class FormProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductos));
            System.Windows.Forms.Label activoLabel;
            System.Windows.Forms.Label capacidadcargaLabel;
            System.Windows.Forms.Label capacidadpasajeroLabel;
            System.Windows.Forms.Label idAvionLabel;
            System.Windows.Forms.Label matriculaavionLabel;
            this.listaVueloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vueloBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.vueloBLBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.vueloBLBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            this.capacidadcargaTextBox = new System.Windows.Forms.TextBox();
            this.capacidadpasajeroTextBox = new System.Windows.Forms.TextBox();
            this.idAvionTextBox = new System.Windows.Forms.TextBox();
            this.matriculaavionTextBox = new System.Windows.Forms.TextBox();
            activoLabel = new System.Windows.Forms.Label();
            capacidadcargaLabel = new System.Windows.Forms.Label();
            capacidadpasajeroLabel = new System.Windows.Forms.Label();
            idAvionLabel = new System.Windows.Forms.Label();
            matriculaavionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaVueloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueloBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueloBLBindingNavigator)).BeginInit();
            this.vueloBLBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // listaVueloBindingSource
            // 
            this.listaVueloBindingSource.DataMember = "ListaVuelo";
            this.listaVueloBindingSource.DataSource = this.vueloBLBindingSource;
            // 
            // vueloBLBindingSource
            // 
            this.vueloBLBindingSource.DataSource = typeof(BL.Rentas.VueloBL);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // vueloBLBindingNavigatorSaveItem
            // 
            this.vueloBLBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.vueloBLBindingNavigatorSaveItem.Enabled = false;
            this.vueloBLBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("vueloBLBindingNavigatorSaveItem.Image")));
            this.vueloBLBindingNavigatorSaveItem.Name = "vueloBLBindingNavigatorSaveItem";
            this.vueloBLBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.vueloBLBindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // vueloBLBindingNavigator
            // 
            this.vueloBLBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.vueloBLBindingNavigator.BindingSource = this.vueloBLBindingSource;
            this.vueloBLBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.vueloBLBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.vueloBLBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.vueloBLBindingNavigatorSaveItem});
            this.vueloBLBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.vueloBLBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.vueloBLBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.vueloBLBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.vueloBLBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.vueloBLBindingNavigator.Name = "vueloBLBindingNavigator";
            this.vueloBLBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.vueloBLBindingNavigator.Size = new System.Drawing.Size(454, 25);
            this.vueloBLBindingNavigator.TabIndex = 0;
            this.vueloBLBindingNavigator.Text = "bindingNavigator1";
            // 
            // activoLabel
            // 
            activoLabel.AutoSize = true;
            activoLabel.Location = new System.Drawing.Point(45, 162);
            activoLabel.Name = "activoLabel";
            activoLabel.Size = new System.Drawing.Size(40, 13);
            activoLabel.TabIndex = 1;
            activoLabel.Text = "Activo:";
            // 
            // activoCheckBox
            // 
            this.activoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.listaVueloBindingSource, "Activo", true));
            this.activoCheckBox.Location = new System.Drawing.Point(151, 157);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(104, 24);
            this.activoCheckBox.TabIndex = 2;
            this.activoCheckBox.UseVisualStyleBackColor = true;
            // 
            // capacidadcargaLabel
            // 
            capacidadcargaLabel.AutoSize = true;
            capacidadcargaLabel.Location = new System.Drawing.Point(45, 134);
            capacidadcargaLabel.Name = "capacidadcargaLabel";
            capacidadcargaLabel.Size = new System.Drawing.Size(87, 13);
            capacidadcargaLabel.TabIndex = 3;
            capacidadcargaLabel.Text = "capacidadcarga:";
            // 
            // capacidadcargaTextBox
            // 
            this.capacidadcargaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaVueloBindingSource, "capacidadcarga", true));
            this.capacidadcargaTextBox.Location = new System.Drawing.Point(151, 131);
            this.capacidadcargaTextBox.Name = "capacidadcargaTextBox";
            this.capacidadcargaTextBox.Size = new System.Drawing.Size(104, 20);
            this.capacidadcargaTextBox.TabIndex = 4;
            // 
            // capacidadpasajeroLabel
            // 
            capacidadpasajeroLabel.AutoSize = true;
            capacidadpasajeroLabel.Location = new System.Drawing.Point(45, 108);
            capacidadpasajeroLabel.Name = "capacidadpasajeroLabel";
            capacidadpasajeroLabel.Size = new System.Drawing.Size(100, 13);
            capacidadpasajeroLabel.TabIndex = 5;
            capacidadpasajeroLabel.Text = "capacidadpasajero:";
            // 
            // capacidadpasajeroTextBox
            // 
            this.capacidadpasajeroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaVueloBindingSource, "capacidadpasajero", true));
            this.capacidadpasajeroTextBox.Location = new System.Drawing.Point(151, 105);
            this.capacidadpasajeroTextBox.Name = "capacidadpasajeroTextBox";
            this.capacidadpasajeroTextBox.Size = new System.Drawing.Size(104, 20);
            this.capacidadpasajeroTextBox.TabIndex = 6;
            // 
            // idAvionLabel
            // 
            idAvionLabel.AutoSize = true;
            idAvionLabel.Location = new System.Drawing.Point(45, 56);
            idAvionLabel.Name = "idAvionLabel";
            idAvionLabel.Size = new System.Drawing.Size(49, 13);
            idAvionLabel.TabIndex = 7;
            idAvionLabel.Text = "Id Avion:";
            // 
            // idAvionTextBox
            // 
            this.idAvionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaVueloBindingSource, "IdAvion", true));
            this.idAvionTextBox.Location = new System.Drawing.Point(151, 53);
            this.idAvionTextBox.Name = "idAvionTextBox";
            this.idAvionTextBox.Size = new System.Drawing.Size(104, 20);
            this.idAvionTextBox.TabIndex = 8;
            // 
            // matriculaavionLabel
            // 
            matriculaavionLabel.AutoSize = true;
            matriculaavionLabel.Location = new System.Drawing.Point(45, 82);
            matriculaavionLabel.Name = "matriculaavionLabel";
            matriculaavionLabel.Size = new System.Drawing.Size(78, 13);
            matriculaavionLabel.TabIndex = 9;
            matriculaavionLabel.Text = "matriculaavion:";
            // 
            // matriculaavionTextBox
            // 
            this.matriculaavionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaVueloBindingSource, "matriculaavion", true));
            this.matriculaavionTextBox.Location = new System.Drawing.Point(151, 79);
            this.matriculaavionTextBox.Name = "matriculaavionTextBox";
            this.matriculaavionTextBox.Size = new System.Drawing.Size(104, 20);
            this.matriculaavionTextBox.TabIndex = 10;
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 346);
            this.Controls.Add(activoLabel);
            this.Controls.Add(this.activoCheckBox);
            this.Controls.Add(capacidadcargaLabel);
            this.Controls.Add(this.capacidadcargaTextBox);
            this.Controls.Add(capacidadpasajeroLabel);
            this.Controls.Add(this.capacidadpasajeroTextBox);
            this.Controls.Add(idAvionLabel);
            this.Controls.Add(this.idAvionTextBox);
            this.Controls.Add(matriculaavionLabel);
            this.Controls.Add(this.matriculaavionTextBox);
            this.Controls.Add(this.vueloBLBindingNavigator);
            this.Name = "FormProductos";
            this.Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)(this.listaVueloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueloBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueloBLBindingNavigator)).EndInit();
            this.vueloBLBindingNavigator.ResumeLayout(false);
            this.vueloBLBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource vueloBLBindingSource;
        private System.Windows.Forms.BindingSource listaVueloBindingSource;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton vueloBLBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator vueloBLBindingNavigator;
        private System.Windows.Forms.CheckBox activoCheckBox;
        private System.Windows.Forms.TextBox capacidadcargaTextBox;
        private System.Windows.Forms.TextBox capacidadpasajeroTextBox;
        private System.Windows.Forms.TextBox idAvionTextBox;
        private System.Windows.Forms.TextBox matriculaavionTextBox;
    }
}