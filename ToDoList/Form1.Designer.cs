namespace ToDoList
{
    partial class FormJanelaToDoList
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblToDoList = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblTarefa = new System.Windows.Forms.Label();
            this.listboxListagemDeTarefas = new System.Windows.Forms.ListBox();
            this.txtTarefa = new System.Windows.Forms.TextBox();
            this.dateTimeData = new System.Windows.Forms.DateTimePicker();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.toolTipMensagem = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblToDoList
            // 
            this.lblToDoList.AutoSize = true;
            this.lblToDoList.Font = new System.Drawing.Font("Segoe UI", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblToDoList.Location = new System.Drawing.Point(247, 30);
            this.lblToDoList.Name = "lblToDoList";
            this.lblToDoList.Size = new System.Drawing.Size(151, 40);
            this.lblToDoList.TabIndex = 0;
            this.lblToDoList.Text = "To Do List";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblData.Location = new System.Drawing.Point(43, 118);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(58, 30);
            this.lblData.TabIndex = 1;
            this.lblData.Text = "Data";
            // 
            // lblTarefa
            // 
            this.lblTarefa.AutoSize = true;
            this.lblTarefa.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTarefa.Location = new System.Drawing.Point(43, 187);
            this.lblTarefa.Name = "lblTarefa";
            this.lblTarefa.Size = new System.Drawing.Size(72, 30);
            this.lblTarefa.TabIndex = 2;
            this.lblTarefa.Text = "Tarefa";
            // 
            // listboxListagemDeTarefas
            // 
            this.listboxListagemDeTarefas.FormattingEnabled = true;
            this.listboxListagemDeTarefas.ItemHeight = 15;
            this.listboxListagemDeTarefas.Items.AddRange(new object[] {
            "Add",
            "Remove"});
            this.listboxListagemDeTarefas.Location = new System.Drawing.Point(60, 257);
            this.listboxListagemDeTarefas.Name = "listboxListagemDeTarefas";
            this.listboxListagemDeTarefas.Size = new System.Drawing.Size(568, 214);
            this.listboxListagemDeTarefas.TabIndex = 3;
            // 
            // txtTarefa
            // 
            this.txtTarefa.Location = new System.Drawing.Point(132, 194);
            this.txtTarefa.Name = "txtTarefa";
            this.txtTarefa.Size = new System.Drawing.Size(244, 23);
            this.txtTarefa.TabIndex = 4;
            this.txtTarefa.TextChanged += new System.EventHandler(this.txtTarefa_TextChanged);
            // 
            // dateTimeData
            // 
            this.dateTimeData.Location = new System.Drawing.Point(132, 124);
            this.dateTimeData.Name = "dateTimeData";
            this.dateTimeData.Size = new System.Drawing.Size(244, 23);
            this.dateTimeData.TabIndex = 5;
            this.toolTipMensagem.SetToolTip(this.dateTimeData, "Digite a data da tarefa!");
            this.dateTimeData.ValueChanged += new System.EventHandler(this.dateTimeData_ValueChanged);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIncluir.Location = new System.Drawing.Point(431, 150);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(158, 41);
            this.btnIncluir.TabIndex = 6;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemover.Location = new System.Drawing.Point(267, 495);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(131, 43);
            this.btnRemover.TabIndex = 7;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // toolTipMensagem
            // 
            this.toolTipMensagem.IsBalloon = true;
            this.toolTipMensagem.ShowAlways = true;
            this.toolTipMensagem.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipMensagem.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTipMensagem_Popup);
            // 
            // FormJanelaToDoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 574);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.dateTimeData);
            this.Controls.Add(this.txtTarefa);
            this.Controls.Add(this.listboxListagemDeTarefas);
            this.Controls.Add(this.lblTarefa);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblToDoList);
            this.Name = "FormJanelaToDoList";
            this.Text = "To Do List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblToDoList;
        private Label lblData;
        private Label lblTarefa;
        private ListBox listboxListagemDeTarefas;
        private TextBox txtTarefa;
        private DateTimePicker dateTimeData;
        private Button btnIncluir;
        private Button btnRemover;
        private ToolTip toolTipMensagem;
    }
}