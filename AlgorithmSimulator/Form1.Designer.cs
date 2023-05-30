
namespace AlgorithmSimulator
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonReverseSortedBubble = new System.Windows.Forms.Button();
            this.buttonNearlySortedBubble = new System.Windows.Forms.Button();
            this.buttonGenerateArrayBubble = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSortedArray = new System.Windows.Forms.TextBox();
            this.labelTimerResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUnsortedArray = new System.Windows.Forms.TextBox();
            this.buttonFreeRunBubble = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonReverseSortedLinear = new System.Windows.Forms.Button();
            this.buttonRandomArrayLinear = new System.Windows.Forms.Button();
            this.labelNumberLocation = new System.Windows.Forms.Label();
            this.buttonFreeRunLinear = new System.Windows.Forms.Button();
            this.labelTimeTakenLinear = new System.Windows.Forms.Label();
            this.comboBoxArrayList = new System.Windows.Forms.ComboBox();
            this.buttonSearchForLinear = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonReverseSortedSelection = new System.Windows.Forms.Button();
            this.buttonNearlySortedSelection = new System.Windows.Forms.Button();
            this.buttonRandomArraySelection = new System.Windows.Forms.Button();
            this.buttonFreeLinear = new System.Windows.Forms.Button();
            this.labelTimeLinear = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSortedLinear = new System.Windows.Forms.TextBox();
            this.textBoxUnsortedLinear = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonGenerateArrayBinary = new System.Windows.Forms.Button();
            this.labelTimeTakenBinary = new System.Windows.Forms.Label();
            this.labelLocationBinary = new System.Windows.Forms.Label();
            this.comboBoxBinaryList = new System.Windows.Forms.ComboBox();
            this.buttonSearchForBinary = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(588, 263);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Silver;
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.buttonReverseSortedBubble);
            this.tabPage1.Controls.Add(this.buttonNearlySortedBubble);
            this.tabPage1.Controls.Add(this.buttonGenerateArrayBubble);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBoxSortedArray);
            this.tabPage1.Controls.Add(this.labelTimerResult);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBoxUnsortedArray);
            this.tabPage1.Controls.Add(this.buttonFreeRunBubble);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(580, 235);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "BubbleSort";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("RM Pro", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(145, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(247, 14);
            this.label7.TabIndex = 9;
            this.label7.Text = "BUBBLE SORT ALGORITHM FREE RUN";
            // 
            // buttonReverseSortedBubble
            // 
            this.buttonReverseSortedBubble.Location = new System.Drawing.Point(332, 28);
            this.buttonReverseSortedBubble.Margin = new System.Windows.Forms.Padding(2);
            this.buttonReverseSortedBubble.Name = "buttonReverseSortedBubble";
            this.buttonReverseSortedBubble.Size = new System.Drawing.Size(173, 30);
            this.buttonReverseSortedBubble.TabIndex = 8;
            this.buttonReverseSortedBubble.Text = "Generate Reverse Sorted Array";
            this.buttonReverseSortedBubble.UseVisualStyleBackColor = true;
            this.buttonReverseSortedBubble.Click += new System.EventHandler(this.buttonReverseSortedBubble_Click);
            // 
            // buttonNearlySortedBubble
            // 
            this.buttonNearlySortedBubble.Location = new System.Drawing.Point(161, 28);
            this.buttonNearlySortedBubble.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNearlySortedBubble.Name = "buttonNearlySortedBubble";
            this.buttonNearlySortedBubble.Size = new System.Drawing.Size(167, 30);
            this.buttonNearlySortedBubble.TabIndex = 7;
            this.buttonNearlySortedBubble.Text = "Generate Nearly Sorted Array";
            this.buttonNearlySortedBubble.UseVisualStyleBackColor = true;
            this.buttonNearlySortedBubble.Click += new System.EventHandler(this.buttonNearlySortedBubble_Click);
            // 
            // buttonGenerateArrayBubble
            // 
            this.buttonGenerateArrayBubble.Location = new System.Drawing.Point(16, 28);
            this.buttonGenerateArrayBubble.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGenerateArrayBubble.Name = "buttonGenerateArrayBubble";
            this.buttonGenerateArrayBubble.Size = new System.Drawing.Size(141, 30);
            this.buttonGenerateArrayBubble.TabIndex = 6;
            this.buttonGenerateArrayBubble.Text = "Generate Random Array";
            this.buttonGenerateArrayBubble.UseVisualStyleBackColor = true;
            this.buttonGenerateArrayBubble.Click += new System.EventHandler(this.buttonGenerateArrayBubble_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sorted Array:";
            // 
            // textBoxSortedArray
            // 
            this.textBoxSortedArray.Location = new System.Drawing.Point(16, 176);
            this.textBoxSortedArray.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSortedArray.Name = "textBoxSortedArray";
            this.textBoxSortedArray.Size = new System.Drawing.Size(553, 23);
            this.textBoxSortedArray.TabIndex = 4;
            // 
            // labelTimerResult
            // 
            this.labelTimerResult.AutoSize = true;
            this.labelTimerResult.Location = new System.Drawing.Point(16, 201);
            this.labelTimerResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTimerResult.Name = "labelTimerResult";
            this.labelTimerResult.Size = new System.Drawing.Size(169, 15);
            this.labelTimerResult.TabIndex = 3;
            this.labelTimerResult.Text = "Time Taken to Sort the Array is:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Array To Sort:";
            // 
            // textBoxUnsortedArray
            // 
            this.textBoxUnsortedArray.Location = new System.Drawing.Point(16, 77);
            this.textBoxUnsortedArray.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUnsortedArray.Name = "textBoxUnsortedArray";
            this.textBoxUnsortedArray.Size = new System.Drawing.Size(553, 23);
            this.textBoxUnsortedArray.TabIndex = 1;
            // 
            // buttonFreeRunBubble
            // 
            this.buttonFreeRunBubble.Location = new System.Drawing.Point(16, 119);
            this.buttonFreeRunBubble.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFreeRunBubble.Name = "buttonFreeRunBubble";
            this.buttonFreeRunBubble.Size = new System.Drawing.Size(80, 29);
            this.buttonFreeRunBubble.TabIndex = 0;
            this.buttonFreeRunBubble.Text = "Free Run";
            this.buttonFreeRunBubble.UseVisualStyleBackColor = true;
            this.buttonFreeRunBubble.Click += new System.EventHandler(this.buttonFreeRunBubble_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Silver;
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.buttonReverseSortedLinear);
            this.tabPage2.Controls.Add(this.buttonRandomArrayLinear);
            this.tabPage2.Controls.Add(this.labelNumberLocation);
            this.tabPage2.Controls.Add(this.buttonFreeRunLinear);
            this.tabPage2.Controls.Add(this.labelTimeTakenLinear);
            this.tabPage2.Controls.Add(this.comboBoxArrayList);
            this.tabPage2.Controls.Add(this.buttonSearchForLinear);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(580, 235);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Linear Search";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("RM Pro", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(156, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(262, 14);
            this.label8.TabIndex = 10;
            this.label8.Text = "LINEAR SEARCH ALGORITHM FREE RUN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 30);
            this.label2.TabIndex = 9;
            this.label2.Text = "Please select a number to search for\r\nfrom the selected array:\r\n";
            // 
            // buttonReverseSortedLinear
            // 
            this.buttonReverseSortedLinear.Location = new System.Drawing.Point(328, 25);
            this.buttonReverseSortedLinear.Margin = new System.Windows.Forms.Padding(2);
            this.buttonReverseSortedLinear.Name = "buttonReverseSortedLinear";
            this.buttonReverseSortedLinear.Size = new System.Drawing.Size(173, 30);
            this.buttonReverseSortedLinear.TabIndex = 8;
            this.buttonReverseSortedLinear.Text = "Generate Reverse Sorted Array";
            this.buttonReverseSortedLinear.UseVisualStyleBackColor = true;
            this.buttonReverseSortedLinear.Click += new System.EventHandler(this.buttonReverseSortedLinear_Click);
            // 
            // buttonRandomArrayLinear
            // 
            this.buttonRandomArrayLinear.Location = new System.Drawing.Point(11, 25);
            this.buttonRandomArrayLinear.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRandomArrayLinear.Name = "buttonRandomArrayLinear";
            this.buttonRandomArrayLinear.Size = new System.Drawing.Size(141, 30);
            this.buttonRandomArrayLinear.TabIndex = 7;
            this.buttonRandomArrayLinear.Text = "Generate Random Array";
            this.buttonRandomArrayLinear.UseVisualStyleBackColor = true;
            this.buttonRandomArrayLinear.Click += new System.EventHandler(this.buttonRandomArrayLinear_Click);
            // 
            // labelNumberLocation
            // 
            this.labelNumberLocation.AutoSize = true;
            this.labelNumberLocation.Location = new System.Drawing.Point(11, 178);
            this.labelNumberLocation.Name = "labelNumberLocation";
            this.labelNumberLocation.Size = new System.Drawing.Size(178, 15);
            this.labelNumberLocation.TabIndex = 6;
            this.labelNumberLocation.Text = "The location of the number is in:";
            // 
            // buttonFreeRunLinear
            // 
            this.buttonFreeRunLinear.Location = new System.Drawing.Point(11, 149);
            this.buttonFreeRunLinear.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFreeRunLinear.Name = "buttonFreeRunLinear";
            this.buttonFreeRunLinear.Size = new System.Drawing.Size(82, 27);
            this.buttonFreeRunLinear.TabIndex = 5;
            this.buttonFreeRunLinear.Text = "Free Run";
            this.buttonFreeRunLinear.UseVisualStyleBackColor = true;
            this.buttonFreeRunLinear.Click += new System.EventHandler(this.buttonFreeRunLinear_Click);
            // 
            // labelTimeTakenLinear
            // 
            this.labelTimeTakenLinear.AutoSize = true;
            this.labelTimeTakenLinear.Location = new System.Drawing.Point(11, 202);
            this.labelTimeTakenLinear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTimeTakenLinear.Name = "labelTimeTakenLinear";
            this.labelTimeTakenLinear.Size = new System.Drawing.Size(152, 15);
            this.labelTimeTakenLinear.TabIndex = 4;
            this.labelTimeTakenLinear.Text = "The Time taken to search is:";
            // 
            // comboBoxArrayList
            // 
            this.comboBoxArrayList.FormattingEnabled = true;
            this.comboBoxArrayList.Location = new System.Drawing.Point(11, 93);
            this.comboBoxArrayList.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxArrayList.Name = "comboBoxArrayList";
            this.comboBoxArrayList.Size = new System.Drawing.Size(129, 23);
            this.comboBoxArrayList.TabIndex = 1;
            // 
            // buttonSearchForLinear
            // 
            this.buttonSearchForLinear.Location = new System.Drawing.Point(156, 25);
            this.buttonSearchForLinear.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSearchForLinear.Name = "buttonSearchForLinear";
            this.buttonSearchForLinear.Size = new System.Drawing.Size(168, 30);
            this.buttonSearchForLinear.TabIndex = 0;
            this.buttonSearchForLinear.Text = "Generate Nearly Sorted Array\r\n";
            this.buttonSearchForLinear.UseVisualStyleBackColor = true;
            this.buttonSearchForLinear.Click += new System.EventHandler(this.buttonSearchForLinear_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Silver;
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.buttonReverseSortedSelection);
            this.tabPage3.Controls.Add(this.buttonNearlySortedSelection);
            this.tabPage3.Controls.Add(this.buttonRandomArraySelection);
            this.tabPage3.Controls.Add(this.buttonFreeLinear);
            this.tabPage3.Controls.Add(this.labelTimeLinear);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.textBoxSortedLinear);
            this.tabPage3.Controls.Add(this.textBoxUnsortedLinear);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(580, 235);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Selection Sort";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("RM Pro", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(157, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(269, 14);
            this.label9.TabIndex = 11;
            this.label9.Text = "SELECTION SORT ALGORITHM FREE RUN";
            // 
            // buttonReverseSortedSelection
            // 
            this.buttonReverseSortedSelection.Location = new System.Drawing.Point(349, 27);
            this.buttonReverseSortedSelection.Name = "buttonReverseSortedSelection";
            this.buttonReverseSortedSelection.Size = new System.Drawing.Size(187, 31);
            this.buttonReverseSortedSelection.TabIndex = 10;
            this.buttonReverseSortedSelection.Text = "Generate Reverse Sorted Array";
            this.buttonReverseSortedSelection.UseVisualStyleBackColor = true;
            this.buttonReverseSortedSelection.Click += new System.EventHandler(this.buttonReverseSortedSelection_Click);
            // 
            // buttonNearlySortedSelection
            // 
            this.buttonNearlySortedSelection.Location = new System.Drawing.Point(174, 27);
            this.buttonNearlySortedSelection.Name = "buttonNearlySortedSelection";
            this.buttonNearlySortedSelection.Size = new System.Drawing.Size(169, 31);
            this.buttonNearlySortedSelection.TabIndex = 9;
            this.buttonNearlySortedSelection.Text = "Generate Nearly Sorted Array";
            this.buttonNearlySortedSelection.UseVisualStyleBackColor = true;
            this.buttonNearlySortedSelection.Click += new System.EventHandler(this.buttonNearlySortedSelection_Click);
            // 
            // buttonRandomArraySelection
            // 
            this.buttonRandomArraySelection.Location = new System.Drawing.Point(17, 27);
            this.buttonRandomArraySelection.Name = "buttonRandomArraySelection";
            this.buttonRandomArraySelection.Size = new System.Drawing.Size(151, 31);
            this.buttonRandomArraySelection.TabIndex = 8;
            this.buttonRandomArraySelection.Text = "Generate Random Array";
            this.buttonRandomArraySelection.UseVisualStyleBackColor = true;
            this.buttonRandomArraySelection.Click += new System.EventHandler(this.buttonRandomArraySelection_Click);
            // 
            // buttonFreeLinear
            // 
            this.buttonFreeLinear.Location = new System.Drawing.Point(17, 115);
            this.buttonFreeLinear.Name = "buttonFreeLinear";
            this.buttonFreeLinear.Size = new System.Drawing.Size(77, 28);
            this.buttonFreeLinear.TabIndex = 7;
            this.buttonFreeLinear.Text = "Free Run";
            this.buttonFreeLinear.UseVisualStyleBackColor = true;
            this.buttonFreeLinear.Click += new System.EventHandler(this.buttonFreeLinear_Click);
            // 
            // labelTimeLinear
            // 
            this.labelTimeLinear.AutoSize = true;
            this.labelTimeLinear.Location = new System.Drawing.Point(18, 199);
            this.labelTimeLinear.Name = "labelTimeLinear";
            this.labelTimeLinear.Size = new System.Drawing.Size(166, 15);
            this.labelTimeLinear.TabIndex = 6;
            this.labelTimeLinear.Text = "Time Taken to sort the array is:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Sorted Array:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Array to Sort:";
            // 
            // textBoxSortedLinear
            // 
            this.textBoxSortedLinear.Location = new System.Drawing.Point(17, 163);
            this.textBoxSortedLinear.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSortedLinear.Name = "textBoxSortedLinear";
            this.textBoxSortedLinear.Size = new System.Drawing.Size(553, 23);
            this.textBoxSortedLinear.TabIndex = 3;
            // 
            // textBoxUnsortedLinear
            // 
            this.textBoxUnsortedLinear.Location = new System.Drawing.Point(17, 78);
            this.textBoxUnsortedLinear.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUnsortedLinear.Name = "textBoxUnsortedLinear";
            this.textBoxUnsortedLinear.Size = new System.Drawing.Size(553, 23);
            this.textBoxUnsortedLinear.TabIndex = 2;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Silver;
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.buttonGenerateArrayBinary);
            this.tabPage4.Controls.Add(this.labelTimeTakenBinary);
            this.tabPage4.Controls.Add(this.labelLocationBinary);
            this.tabPage4.Controls.Add(this.comboBoxBinaryList);
            this.tabPage4.Controls.Add(this.buttonSearchForBinary);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(580, 235);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Binary Search";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("RM Pro", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(146, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(264, 14);
            this.label10.TabIndex = 10;
            this.label10.Text = "BINARY SEARCH ALGORITHM FREE RUN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(263, 30);
            this.label6.TabIndex = 5;
            this.label6.Text = "Please select from the drop down list what\r\nnumber in the array you would like to" +
    " search for:";
            // 
            // buttonGenerateArrayBinary
            // 
            this.buttonGenerateArrayBinary.Location = new System.Drawing.Point(8, 38);
            this.buttonGenerateArrayBinary.Name = "buttonGenerateArrayBinary";
            this.buttonGenerateArrayBinary.Size = new System.Drawing.Size(165, 30);
            this.buttonGenerateArrayBinary.TabIndex = 4;
            this.buttonGenerateArrayBinary.Text = "Generate Array of Numbers";
            this.buttonGenerateArrayBinary.UseVisualStyleBackColor = true;
            this.buttonGenerateArrayBinary.Click += new System.EventHandler(this.buttonGenerateArrayBinary_Click);
            // 
            // labelTimeTakenBinary
            // 
            this.labelTimeTakenBinary.AutoSize = true;
            this.labelTimeTakenBinary.Location = new System.Drawing.Point(8, 201);
            this.labelTimeTakenBinary.Name = "labelTimeTakenBinary";
            this.labelTimeTakenBinary.Size = new System.Drawing.Size(192, 15);
            this.labelTimeTakenBinary.TabIndex = 3;
            this.labelTimeTakenBinary.Text = "The time taken for the algorithm is:";
            // 
            // labelLocationBinary
            // 
            this.labelLocationBinary.AutoSize = true;
            this.labelLocationBinary.Location = new System.Drawing.Point(8, 177);
            this.labelLocationBinary.Name = "labelLocationBinary";
            this.labelLocationBinary.Size = new System.Drawing.Size(165, 15);
            this.labelLocationBinary.TabIndex = 2;
            this.labelLocationBinary.Text = "The location of the number is:";
            // 
            // comboBoxBinaryList
            // 
            this.comboBoxBinaryList.FormattingEnabled = true;
            this.comboBoxBinaryList.Location = new System.Drawing.Point(277, 78);
            this.comboBoxBinaryList.Name = "comboBoxBinaryList";
            this.comboBoxBinaryList.Size = new System.Drawing.Size(138, 23);
            this.comboBoxBinaryList.TabIndex = 1;
            // 
            // buttonSearchForBinary
            // 
            this.buttonSearchForBinary.Location = new System.Drawing.Point(8, 136);
            this.buttonSearchForBinary.Name = "buttonSearchForBinary";
            this.buttonSearchForBinary.Size = new System.Drawing.Size(81, 30);
            this.buttonSearchForBinary.TabIndex = 0;
            this.buttonSearchForBinary.Text = "Free Run";
            this.buttonSearchForBinary.UseVisualStyleBackColor = true;
            this.buttonSearchForBinary.Click += new System.EventHandler(this.buttonSearchForBinary_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 261);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonFreeRunBubble;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label labelTimerResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUnsortedArray;
        private System.Windows.Forms.ComboBox comboBoxArrayList;
        private System.Windows.Forms.Button buttonSearchForLinear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSortedArray;
        private System.Windows.Forms.Label labelTimeTakenLinear;
        private System.Windows.Forms.Button buttonFreeRunLinear;
        private System.Windows.Forms.Label labelNumberLocation;
        private System.Windows.Forms.Button buttonGenerateArrayBubble;
        private System.Windows.Forms.Button buttonReverseSortedBubble;
        private System.Windows.Forms.Button buttonNearlySortedBubble;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonReverseSortedLinear;
        private System.Windows.Forms.Button buttonRandomArrayLinear;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label labelTimeLinear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSortedLinear;
        private System.Windows.Forms.TextBox textBoxUnsortedLinear;
        private System.Windows.Forms.Button buttonFreeLinear;
        private System.Windows.Forms.Button buttonReverseSortedSelection;
        private System.Windows.Forms.Button buttonNearlySortedSelection;
        private System.Windows.Forms.Button buttonRandomArraySelection;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label labelTimeTakenBinary;
        private System.Windows.Forms.Label labelLocationBinary;
        private System.Windows.Forms.ComboBox comboBoxBinaryList;
        private System.Windows.Forms.Button buttonSearchForBinary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonGenerateArrayBinary;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

