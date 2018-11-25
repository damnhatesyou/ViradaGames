using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ViradaGames
{
    partial class ViradaGames
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.itemInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.retailPriceItemInfoTextBox = new System.Windows.Forms.TextBox();
            this.stockQuantityItemInfoTextBox = new System.Windows.Forms.TextBox();
            this.descriptionItemInfoTextBox = new System.Windows.Forms.TextBox();
            this.productIDItemInfoTextBox = new System.Windows.Forms.TextBox();
            this.retailPriceItemInfoLabel = new System.Windows.Forms.Label();
            this.stockQuantityItemInfoLabel = new System.Windows.Forms.Label();
            this.descriptionItemInfoLabel = new System.Windows.Forms.Label();
            this.productIDItemInfoLabel = new System.Windows.Forms.Label();
            this.gamesGroupBox = new System.Windows.Forms.GroupBox();
            this.mediaTypeGamesTextBox = new System.Windows.Forms.TextBox();
            this.publisherGamesTextBox = new System.Windows.Forms.TextBox();
            this.mediaTypeGamesLabel = new System.Windows.Forms.Label();
            this.publisherGamesLabel = new System.Windows.Forms.Label();
            this.platformsGroupBox = new System.Windows.Forms.GroupBox();
            this.modelNumberPlatformsTextBox = new System.Windows.Forms.TextBox();
            this.modelNumberPlatformsLabel = new System.Windows.Forms.Label();
            this.accessoriesGroupBox = new System.Windows.Forms.GroupBox();
            this.platformTypeAccessoriesTextBox = new System.Windows.Forms.TextBox();
            this.platformTypeAccessoriesLabel = new System.Windows.Forms.Label();
            this.customerGroupBox = new System.Windows.Forms.GroupBox();
            this.emailCustomerTextBox = new System.Windows.Forms.TextBox();
            this.customerIDCustomerLabel = new System.Windows.Forms.Label();
            this.firstNameCustomerTextBox = new System.Windows.Forms.TextBox();
            this.familyNameCustomerLabel = new System.Windows.Forms.Label();
            this.familyNameCustomerTextBox = new System.Windows.Forms.TextBox();
            this.firstNameCustomerLabel = new System.Windows.Forms.Label();
            this.CustomerIDCustomerTextBox = new System.Windows.Forms.TextBox();
            this.emailCustomerLabel = new System.Windows.Forms.Label();
            this.transactionsInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.retailPriceTransactionTextBox = new System.Windows.Forms.TextBox();
            this.productIDTransactionTextBox = new System.Windows.Forms.TextBox();
            this.retailPriceTransactionsLabel = new System.Windows.Forms.Label();
            this.dateTransactionTextBox = new System.Windows.Forms.TextBox();
            this.productIDTransactionsLabel = new System.Windows.Forms.Label();
            this.dateTransactionsLabel = new System.Windows.Forms.Label();
            this.customerIDTransactionsLabel = new System.Windows.Forms.Label();
            this.quantityTransactionTextBox = new System.Windows.Forms.TextBox();
            this.customerIDTransactionTextBox = new System.Windows.Forms.TextBox();
            this.quantityTransactionsLabel = new System.Windows.Forms.Label();
            this.productsLabel = new System.Windows.Forms.Label();
            this.productAddButton = new System.Windows.Forms.Button();
            this.productsListBox = new System.Windows.Forms.ListBox();
            this.customerLabel = new System.Windows.Forms.Label();
            this.transactionsLabel = new System.Windows.Forms.Label();
            this.customerAddButton = new System.Windows.Forms.Button();
            this.transactionAddButton = new System.Windows.Forms.Button();
            this.customerListBox = new System.Windows.Forms.ListBox();
            this.transactionListBox = new System.Windows.Forms.ListBox();
            this.itemInfoGroupBox.SuspendLayout();
            this.gamesGroupBox.SuspendLayout();
            this.platformsGroupBox.SuspendLayout();
            this.accessoriesGroupBox.SuspendLayout();
            this.customerGroupBox.SuspendLayout();
            this.transactionsInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemInfoGroupBox
            // 
            this.itemInfoGroupBox.Controls.Add(this.retailPriceItemInfoTextBox);
            this.itemInfoGroupBox.Controls.Add(this.stockQuantityItemInfoTextBox);
            this.itemInfoGroupBox.Controls.Add(this.descriptionItemInfoTextBox);
            this.itemInfoGroupBox.Controls.Add(this.productIDItemInfoTextBox);
            this.itemInfoGroupBox.Controls.Add(this.retailPriceItemInfoLabel);
            this.itemInfoGroupBox.Controls.Add(this.stockQuantityItemInfoLabel);
            this.itemInfoGroupBox.Controls.Add(this.descriptionItemInfoLabel);
            this.itemInfoGroupBox.Controls.Add(this.productIDItemInfoLabel);
            this.itemInfoGroupBox.Location = new System.Drawing.Point(23, 27);
            this.itemInfoGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.itemInfoGroupBox.Name = "itemInfoGroupBox";
            this.itemInfoGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.itemInfoGroupBox.Size = new System.Drawing.Size(420, 373);
            this.itemInfoGroupBox.TabIndex = 0;
            this.itemInfoGroupBox.TabStop = false;
            this.itemInfoGroupBox.Text = "Item Info";
            // 
            // retailPriceItemInfoTextBox
            // 
            this.retailPriceItemInfoTextBox.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.retailPriceItemInfoTextBox.Location = new System.Drawing.Point(229, 274);
            this.retailPriceItemInfoTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.retailPriceItemInfoTextBox.Name = "retailPriceItemInfoTextBox";
            this.retailPriceItemInfoTextBox.Size = new System.Drawing.Size(158, 35);
            this.retailPriceItemInfoTextBox.TabIndex = 7;
            // 
            // stockQuantityItemInfoTextBox
            // 
            this.stockQuantityItemInfoTextBox.Location = new System.Drawing.Point(229, 194);
            this.stockQuantityItemInfoTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.stockQuantityItemInfoTextBox.Name = "stockQuantityItemInfoTextBox";
            this.stockQuantityItemInfoTextBox.Size = new System.Drawing.Size(158, 35);
            this.stockQuantityItemInfoTextBox.TabIndex = 6;
            // 
            // descriptionItemInfoTextBox
            // 
            this.descriptionItemInfoTextBox.Location = new System.Drawing.Point(229, 125);
            this.descriptionItemInfoTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.descriptionItemInfoTextBox.Name = "descriptionItemInfoTextBox";
            this.descriptionItemInfoTextBox.Size = new System.Drawing.Size(158, 35);
            this.descriptionItemInfoTextBox.TabIndex = 5;
            // 
            // productIDItemInfoTextBox
            // 
            this.productIDItemInfoTextBox.BackColor = System.Drawing.Color.Khaki;
            this.productIDItemInfoTextBox.Location = new System.Drawing.Point(229, 65);
            this.productIDItemInfoTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.productIDItemInfoTextBox.Name = "productIDItemInfoTextBox";
            this.productIDItemInfoTextBox.Size = new System.Drawing.Size(158, 35);
            this.productIDItemInfoTextBox.TabIndex = 4;
            // 
            // retailPriceItemInfoLabel
            // 
            this.retailPriceItemInfoLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.retailPriceItemInfoLabel.AutoSize = true;
            this.retailPriceItemInfoLabel.Location = new System.Drawing.Point(35, 274);
            this.retailPriceItemInfoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.retailPriceItemInfoLabel.Name = "retailPriceItemInfoLabel";
            this.retailPriceItemInfoLabel.Size = new System.Drawing.Size(137, 29);
            this.retailPriceItemInfoLabel.TabIndex = 3;
            this.retailPriceItemInfoLabel.Text = "Retail Price";
            // 
            // stockQuantityItemInfoLabel
            // 
            this.stockQuantityItemInfoLabel.AutoSize = true;
            this.stockQuantityItemInfoLabel.Location = new System.Drawing.Point(35, 194);
            this.stockQuantityItemInfoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stockQuantityItemInfoLabel.Name = "stockQuantityItemInfoLabel";
            this.stockQuantityItemInfoLabel.Size = new System.Drawing.Size(166, 29);
            this.stockQuantityItemInfoLabel.TabIndex = 2;
            this.stockQuantityItemInfoLabel.Text = "Stock Quantity";
            // 
            // descriptionItemInfoLabel
            // 
            this.descriptionItemInfoLabel.AutoSize = true;
            this.descriptionItemInfoLabel.Location = new System.Drawing.Point(35, 125);
            this.descriptionItemInfoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.descriptionItemInfoLabel.Name = "descriptionItemInfoLabel";
            this.descriptionItemInfoLabel.Size = new System.Drawing.Size(135, 29);
            this.descriptionItemInfoLabel.TabIndex = 1;
            this.descriptionItemInfoLabel.Text = "Description";
            // 
            // productIDItemInfoLabel
            // 
            this.productIDItemInfoLabel.AutoSize = true;
            this.productIDItemInfoLabel.Location = new System.Drawing.Point(35, 65);
            this.productIDItemInfoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.productIDItemInfoLabel.Name = "productIDItemInfoLabel";
            this.productIDItemInfoLabel.Size = new System.Drawing.Size(125, 29);
            this.productIDItemInfoLabel.TabIndex = 0;
            this.productIDItemInfoLabel.Text = "Product ID";
            // 
            // gamesGroupBox
            // 
            this.gamesGroupBox.Controls.Add(this.mediaTypeGamesTextBox);
            this.gamesGroupBox.Controls.Add(this.publisherGamesTextBox);
            this.gamesGroupBox.Controls.Add(this.mediaTypeGamesLabel);
            this.gamesGroupBox.Controls.Add(this.publisherGamesLabel);
            this.gamesGroupBox.Location = new System.Drawing.Point(23, 437);
            this.gamesGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.gamesGroupBox.Name = "gamesGroupBox";
            this.gamesGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.gamesGroupBox.Size = new System.Drawing.Size(420, 272);
            this.gamesGroupBox.TabIndex = 1;
            this.gamesGroupBox.TabStop = false;
            this.gamesGroupBox.Text = "Games";
            // 
            // mediaTypeGamesTextBox
            // 
            this.mediaTypeGamesTextBox.Location = new System.Drawing.Point(229, 161);
            this.mediaTypeGamesTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.mediaTypeGamesTextBox.Name = "mediaTypeGamesTextBox";
            this.mediaTypeGamesTextBox.Size = new System.Drawing.Size(158, 35);
            this.mediaTypeGamesTextBox.TabIndex = 3;
            // 
            // publisherGamesTextBox
            // 
            this.publisherGamesTextBox.Location = new System.Drawing.Point(229, 76);
            this.publisherGamesTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.publisherGamesTextBox.Name = "publisherGamesTextBox";
            this.publisherGamesTextBox.Size = new System.Drawing.Size(158, 35);
            this.publisherGamesTextBox.TabIndex = 2;
            // 
            // mediaTypeGamesLabel
            // 
            this.mediaTypeGamesLabel.AutoSize = true;
            this.mediaTypeGamesLabel.Location = new System.Drawing.Point(40, 167);
            this.mediaTypeGamesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mediaTypeGamesLabel.Name = "mediaTypeGamesLabel";
            this.mediaTypeGamesLabel.Size = new System.Drawing.Size(141, 29);
            this.mediaTypeGamesLabel.TabIndex = 1;
            this.mediaTypeGamesLabel.Text = "Media Type";
            // 
            // publisherGamesLabel
            // 
            this.publisherGamesLabel.AutoSize = true;
            this.publisherGamesLabel.Location = new System.Drawing.Point(40, 76);
            this.publisherGamesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.publisherGamesLabel.Name = "publisherGamesLabel";
            this.publisherGamesLabel.Size = new System.Drawing.Size(115, 29);
            this.publisherGamesLabel.TabIndex = 0;
            this.publisherGamesLabel.Text = "Publisher";
            // 
            // platformsGroupBox
            // 
            this.platformsGroupBox.Controls.Add(this.modelNumberPlatformsTextBox);
            this.platformsGroupBox.Controls.Add(this.modelNumberPlatformsLabel);
            this.platformsGroupBox.Location = new System.Drawing.Point(23, 743);
            this.platformsGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.platformsGroupBox.Name = "platformsGroupBox";
            this.platformsGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.platformsGroupBox.Size = new System.Drawing.Size(420, 156);
            this.platformsGroupBox.TabIndex = 1;
            this.platformsGroupBox.TabStop = false;
            this.platformsGroupBox.Text = "Platforms";
            // 
            // modelNumberPlatformsTextBox
            // 
            this.modelNumberPlatformsTextBox.Location = new System.Drawing.Point(222, 54);
            this.modelNumberPlatformsTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.modelNumberPlatformsTextBox.Name = "modelNumberPlatformsTextBox";
            this.modelNumberPlatformsTextBox.Size = new System.Drawing.Size(158, 35);
            this.modelNumberPlatformsTextBox.TabIndex = 1;
            // 
            // modelNumberPlatformsLabel
            // 
            this.modelNumberPlatformsLabel.AutoSize = true;
            this.modelNumberPlatformsLabel.Location = new System.Drawing.Point(40, 60);
            this.modelNumberPlatformsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.modelNumberPlatformsLabel.Name = "modelNumberPlatformsLabel";
            this.modelNumberPlatformsLabel.Size = new System.Drawing.Size(174, 29);
            this.modelNumberPlatformsLabel.TabIndex = 0;
            this.modelNumberPlatformsLabel.Text = "Model Number";
            // 
            // accessoriesGroupBox
            // 
            this.accessoriesGroupBox.Controls.Add(this.platformTypeAccessoriesTextBox);
            this.accessoriesGroupBox.Controls.Add(this.platformTypeAccessoriesLabel);
            this.accessoriesGroupBox.Location = new System.Drawing.Point(23, 930);
            this.accessoriesGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.accessoriesGroupBox.Name = "accessoriesGroupBox";
            this.accessoriesGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.accessoriesGroupBox.Size = new System.Drawing.Size(420, 134);
            this.accessoriesGroupBox.TabIndex = 1;
            this.accessoriesGroupBox.TabStop = false;
            this.accessoriesGroupBox.Text = "Accessories";
            // 
            // platformTypeAccessoriesTextBox
            // 
            this.platformTypeAccessoriesTextBox.Location = new System.Drawing.Point(229, 47);
            this.platformTypeAccessoriesTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.platformTypeAccessoriesTextBox.Name = "platformTypeAccessoriesTextBox";
            this.platformTypeAccessoriesTextBox.Size = new System.Drawing.Size(158, 35);
            this.platformTypeAccessoriesTextBox.TabIndex = 1;
            // 
            // platformTypeAccessoriesLabel
            // 
            this.platformTypeAccessoriesLabel.AutoSize = true;
            this.platformTypeAccessoriesLabel.Location = new System.Drawing.Point(35, 54);
            this.platformTypeAccessoriesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.platformTypeAccessoriesLabel.Name = "platformTypeAccessoriesLabel";
            this.platformTypeAccessoriesLabel.Size = new System.Drawing.Size(163, 29);
            this.platformTypeAccessoriesLabel.TabIndex = 0;
            this.platformTypeAccessoriesLabel.Text = "Platform Type";
            // 
            // customerGroupBox
            // 
            this.customerGroupBox.Controls.Add(this.emailCustomerTextBox);
            this.customerGroupBox.Controls.Add(this.customerIDCustomerLabel);
            this.customerGroupBox.Controls.Add(this.firstNameCustomerTextBox);
            this.customerGroupBox.Controls.Add(this.familyNameCustomerLabel);
            this.customerGroupBox.Controls.Add(this.familyNameCustomerTextBox);
            this.customerGroupBox.Controls.Add(this.firstNameCustomerLabel);
            this.customerGroupBox.Controls.Add(this.CustomerIDCustomerTextBox);
            this.customerGroupBox.Controls.Add(this.emailCustomerLabel);
            this.customerGroupBox.Location = new System.Drawing.Point(966, 67);
            this.customerGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.customerGroupBox.Name = "customerGroupBox";
            this.customerGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.customerGroupBox.Size = new System.Drawing.Size(420, 424);
            this.customerGroupBox.TabIndex = 1;
            this.customerGroupBox.TabStop = false;
            this.customerGroupBox.Text = "Customer Info";
            // 
            // emailCustomerTextBox
            // 
            this.emailCustomerTextBox.Location = new System.Drawing.Point(203, 248);
            this.emailCustomerTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.emailCustomerTextBox.Name = "emailCustomerTextBox";
            this.emailCustomerTextBox.Size = new System.Drawing.Size(158, 35);
            this.emailCustomerTextBox.TabIndex = 15;
            // 
            // customerIDCustomerLabel
            // 
            this.customerIDCustomerLabel.AutoSize = true;
            this.customerIDCustomerLabel.Location = new System.Drawing.Point(21, 56);
            this.customerIDCustomerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customerIDCustomerLabel.Name = "customerIDCustomerLabel";
            this.customerIDCustomerLabel.Size = new System.Drawing.Size(146, 29);
            this.customerIDCustomerLabel.TabIndex = 8;
            this.customerIDCustomerLabel.Text = "Customer ID";
            // 
            // firstNameCustomerTextBox
            // 
            this.firstNameCustomerTextBox.Location = new System.Drawing.Point(203, 185);
            this.firstNameCustomerTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.firstNameCustomerTextBox.Name = "firstNameCustomerTextBox";
            this.firstNameCustomerTextBox.Size = new System.Drawing.Size(158, 35);
            this.firstNameCustomerTextBox.TabIndex = 14;
            // 
            // familyNameCustomerLabel
            // 
            this.familyNameCustomerLabel.AutoSize = true;
            this.familyNameCustomerLabel.Location = new System.Drawing.Point(21, 116);
            this.familyNameCustomerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.familyNameCustomerLabel.Name = "familyNameCustomerLabel";
            this.familyNameCustomerLabel.Size = new System.Drawing.Size(155, 29);
            this.familyNameCustomerLabel.TabIndex = 9;
            this.familyNameCustomerLabel.Text = "Family Name";
            // 
            // familyNameCustomerTextBox
            // 
            this.familyNameCustomerTextBox.Location = new System.Drawing.Point(203, 116);
            this.familyNameCustomerTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.familyNameCustomerTextBox.Name = "familyNameCustomerTextBox";
            this.familyNameCustomerTextBox.Size = new System.Drawing.Size(158, 35);
            this.familyNameCustomerTextBox.TabIndex = 13;
            // 
            // firstNameCustomerLabel
            // 
            this.firstNameCustomerLabel.AutoSize = true;
            this.firstNameCustomerLabel.Location = new System.Drawing.Point(21, 185);
            this.firstNameCustomerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.firstNameCustomerLabel.Name = "firstNameCustomerLabel";
            this.firstNameCustomerLabel.Size = new System.Drawing.Size(131, 29);
            this.firstNameCustomerLabel.TabIndex = 10;
            this.firstNameCustomerLabel.Text = "First Name";
            // 
            // CustomerIDCustomerTextBox
            // 
            this.CustomerIDCustomerTextBox.BackColor = System.Drawing.Color.Crimson;
            this.CustomerIDCustomerTextBox.Location = new System.Drawing.Point(203, 56);
            this.CustomerIDCustomerTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.CustomerIDCustomerTextBox.Name = "CustomerIDCustomerTextBox";
            this.CustomerIDCustomerTextBox.Size = new System.Drawing.Size(158, 35);
            this.CustomerIDCustomerTextBox.TabIndex = 12;
            // 
            // emailCustomerLabel
            // 
            this.emailCustomerLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.emailCustomerLabel.AutoSize = true;
            this.emailCustomerLabel.Location = new System.Drawing.Point(21, 248);
            this.emailCustomerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emailCustomerLabel.Name = "emailCustomerLabel";
            this.emailCustomerLabel.Size = new System.Drawing.Size(74, 29);
            this.emailCustomerLabel.TabIndex = 11;
            this.emailCustomerLabel.Text = "Email";
            // 
            // transactionsInfoGroupBox
            // 
            this.transactionsInfoGroupBox.Controls.Add(this.retailPriceTransactionTextBox);
            this.transactionsInfoGroupBox.Controls.Add(this.productIDTransactionTextBox);
            this.transactionsInfoGroupBox.Controls.Add(this.retailPriceTransactionsLabel);
            this.transactionsInfoGroupBox.Controls.Add(this.dateTransactionTextBox);
            this.transactionsInfoGroupBox.Controls.Add(this.productIDTransactionsLabel);
            this.transactionsInfoGroupBox.Controls.Add(this.dateTransactionsLabel);
            this.transactionsInfoGroupBox.Controls.Add(this.customerIDTransactionsLabel);
            this.transactionsInfoGroupBox.Controls.Add(this.quantityTransactionTextBox);
            this.transactionsInfoGroupBox.Controls.Add(this.customerIDTransactionTextBox);
            this.transactionsInfoGroupBox.Controls.Add(this.quantityTransactionsLabel);
            this.transactionsInfoGroupBox.Location = new System.Drawing.Point(966, 642);
            this.transactionsInfoGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.transactionsInfoGroupBox.Name = "transactionsInfoGroupBox";
            this.transactionsInfoGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.transactionsInfoGroupBox.Size = new System.Drawing.Size(420, 424);
            this.transactionsInfoGroupBox.TabIndex = 1;
            this.transactionsInfoGroupBox.TabStop = false;
            this.transactionsInfoGroupBox.Text = "Transactions Info";
            // 
            // retailPriceTransactionTextBox
            // 
            this.retailPriceTransactionTextBox.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.retailPriceTransactionTextBox.Location = new System.Drawing.Point(203, 248);
            this.retailPriceTransactionTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.retailPriceTransactionTextBox.Name = "retailPriceTransactionTextBox";
            this.retailPriceTransactionTextBox.ReadOnly = true;
            this.retailPriceTransactionTextBox.Size = new System.Drawing.Size(158, 35);
            this.retailPriceTransactionTextBox.TabIndex = 9;
            // 
            // productIDTransactionTextBox
            // 
            this.productIDTransactionTextBox.BackColor = System.Drawing.Color.Khaki;
            this.productIDTransactionTextBox.Location = new System.Drawing.Point(203, 125);
            this.productIDTransactionTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.productIDTransactionTextBox.Name = "productIDTransactionTextBox";
            this.productIDTransactionTextBox.ReadOnly = true;
            this.productIDTransactionTextBox.Size = new System.Drawing.Size(158, 35);
            this.productIDTransactionTextBox.TabIndex = 9;
            // 
            // retailPriceTransactionsLabel
            // 
            this.retailPriceTransactionsLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.retailPriceTransactionsLabel.AutoSize = true;
            this.retailPriceTransactionsLabel.Location = new System.Drawing.Point(21, 248);
            this.retailPriceTransactionsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.retailPriceTransactionsLabel.Name = "retailPriceTransactionsLabel";
            this.retailPriceTransactionsLabel.Size = new System.Drawing.Size(137, 29);
            this.retailPriceTransactionsLabel.TabIndex = 8;
            this.retailPriceTransactionsLabel.Text = "Retail Price";
            // 
            // dateTransactionTextBox
            // 
            this.dateTransactionTextBox.Location = new System.Drawing.Point(203, 308);
            this.dateTransactionTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.dateTransactionTextBox.Name = "dateTransactionTextBox";
            this.dateTransactionTextBox.Size = new System.Drawing.Size(158, 35);
            this.dateTransactionTextBox.TabIndex = 25;
            // 
            // productIDTransactionsLabel
            // 
            this.productIDTransactionsLabel.AutoSize = true;
            this.productIDTransactionsLabel.Location = new System.Drawing.Point(21, 125);
            this.productIDTransactionsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.productIDTransactionsLabel.Name = "productIDTransactionsLabel";
            this.productIDTransactionsLabel.Size = new System.Drawing.Size(125, 29);
            this.productIDTransactionsLabel.TabIndex = 8;
            this.productIDTransactionsLabel.Text = "Product ID";
            // 
            // dateTransactionsLabel
            // 
            this.dateTransactionsLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.dateTransactionsLabel.AutoSize = true;
            this.dateTransactionsLabel.Location = new System.Drawing.Point(21, 308);
            this.dateTransactionsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateTransactionsLabel.Name = "dateTransactionsLabel";
            this.dateTransactionsLabel.Size = new System.Drawing.Size(63, 29);
            this.dateTransactionsLabel.TabIndex = 24;
            this.dateTransactionsLabel.Text = "Date";
            // 
            // customerIDTransactionsLabel
            // 
            this.customerIDTransactionsLabel.AutoSize = true;
            this.customerIDTransactionsLabel.Location = new System.Drawing.Point(21, 62);
            this.customerIDTransactionsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customerIDTransactionsLabel.Name = "customerIDTransactionsLabel";
            this.customerIDTransactionsLabel.Size = new System.Drawing.Size(146, 29);
            this.customerIDTransactionsLabel.TabIndex = 16;
            this.customerIDTransactionsLabel.Text = "Customer ID";
            // 
            // quantityTransactionTextBox
            // 
            this.quantityTransactionTextBox.Location = new System.Drawing.Point(203, 192);
            this.quantityTransactionTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.quantityTransactionTextBox.Name = "quantityTransactionTextBox";
            this.quantityTransactionTextBox.Size = new System.Drawing.Size(158, 35);
            this.quantityTransactionTextBox.TabIndex = 22;
            // 
            // customerIDTransactionTextBox
            // 
            this.customerIDTransactionTextBox.BackColor = System.Drawing.Color.Crimson;
            this.customerIDTransactionTextBox.Location = new System.Drawing.Point(203, 62);
            this.customerIDTransactionTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.customerIDTransactionTextBox.Name = "customerIDTransactionTextBox";
            this.customerIDTransactionTextBox.ReadOnly = true;
            this.customerIDTransactionTextBox.Size = new System.Drawing.Size(158, 35);
            this.customerIDTransactionTextBox.TabIndex = 20;
            // 
            // quantityTransactionsLabel
            // 
            this.quantityTransactionsLabel.AutoSize = true;
            this.quantityTransactionsLabel.Location = new System.Drawing.Point(21, 192);
            this.quantityTransactionsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.quantityTransactionsLabel.Name = "quantityTransactionsLabel";
            this.quantityTransactionsLabel.Size = new System.Drawing.Size(100, 29);
            this.quantityTransactionsLabel.TabIndex = 18;
            this.quantityTransactionsLabel.Text = "Quantity";
            // 
            // productsLabel
            // 
            this.productsLabel.AutoSize = true;
            this.productsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsLabel.Location = new System.Drawing.Point(614, 27);
            this.productsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.productsLabel.Name = "productsLabel";
            this.productsLabel.Size = new System.Drawing.Size(142, 36);
            this.productsLabel.TabIndex = 2;
            this.productsLabel.Text = "Products";
            // 
            // productAddButton
            // 
            this.productAddButton.Location = new System.Drawing.Point(506, 67);
            this.productAddButton.Margin = new System.Windows.Forms.Padding(2);
            this.productAddButton.Name = "productAddButton";
            this.productAddButton.Size = new System.Drawing.Size(399, 62);
            this.productAddButton.TabIndex = 3;
            this.productAddButton.Text = "ADD";
            this.productAddButton.UseVisualStyleBackColor = true;
            this.productAddButton.Click += new System.EventHandler(this.productAddButton_Click);
            // 
            // productsListBox
            // 
            this.productsListBox.FormattingEnabled = true;
            this.productsListBox.ItemHeight = 29;
            this.productsListBox.Location = new System.Drawing.Point(502, 156);
            this.productsListBox.Margin = new System.Windows.Forms.Padding(2);
            this.productsListBox.Name = "productsListBox";
            this.productsListBox.Size = new System.Drawing.Size(403, 903);
            this.productsListBox.TabIndex = 4;
            this.productsListBox.SelectedIndexChanged += new System.EventHandler(this.productsListBox_SelectedIndexChanged);
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLabel.Location = new System.Drawing.Point(1048, 27);
            this.customerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(166, 36);
            this.customerLabel.TabIndex = 5;
            this.customerLabel.Text = "Customers";
            // 
            // transactionsLabel
            // 
            this.transactionsLabel.AutoSize = true;
            this.transactionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionsLabel.Location = new System.Drawing.Point(1048, 578);
            this.transactionsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.transactionsLabel.Name = "transactionsLabel";
            this.transactionsLabel.Size = new System.Drawing.Size(198, 36);
            this.transactionsLabel.TabIndex = 6;
            this.transactionsLabel.Text = "Transactions";
            // 
            // customerAddButton
            // 
            this.customerAddButton.Location = new System.Drawing.Point(1435, 27);
            this.customerAddButton.Margin = new System.Windows.Forms.Padding(2);
            this.customerAddButton.Name = "customerAddButton";
            this.customerAddButton.Size = new System.Drawing.Size(399, 62);
            this.customerAddButton.TabIndex = 7;
            this.customerAddButton.Text = "ADD";
            this.customerAddButton.UseVisualStyleBackColor = true;
            this.customerAddButton.Click += new System.EventHandler(this.customerAddButton_Click);
            // 
            // transactionAddButton
            // 
            this.transactionAddButton.Location = new System.Drawing.Point(1435, 564);
            this.transactionAddButton.Margin = new System.Windows.Forms.Padding(2);
            this.transactionAddButton.Name = "transactionAddButton";
            this.transactionAddButton.Size = new System.Drawing.Size(399, 62);
            this.transactionAddButton.TabIndex = 8;
            this.transactionAddButton.Text = "ADD";
            this.transactionAddButton.UseVisualStyleBackColor = true;
            this.transactionAddButton.Click += new System.EventHandler(this.transactionAddButton_Click);
            // 
            // customerListBox
            // 
            this.customerListBox.FormattingEnabled = true;
            this.customerListBox.ItemHeight = 29;
            this.customerListBox.Location = new System.Drawing.Point(1435, 118);
            this.customerListBox.Margin = new System.Windows.Forms.Padding(2);
            this.customerListBox.Name = "customerListBox";
            this.customerListBox.Size = new System.Drawing.Size(403, 410);
            this.customerListBox.TabIndex = 9;
            this.customerListBox.SelectedIndexChanged += new System.EventHandler(this.customerListBox_SelectedIndexChanged);
            // 
            // transactionListBox
            // 
            this.transactionListBox.FormattingEnabled = true;
            this.transactionListBox.ItemHeight = 29;
            this.transactionListBox.Location = new System.Drawing.Point(1435, 642);
            this.transactionListBox.Margin = new System.Windows.Forms.Padding(2);
            this.transactionListBox.Name = "transactionListBox";
            this.transactionListBox.Size = new System.Drawing.Size(403, 410);
            this.transactionListBox.TabIndex = 10;
            this.transactionListBox.SelectedIndexChanged += new System.EventHandler(this.transactionListBox_SelectedIndexChanged);
            // 
            // ViradaGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1881, 1095);
            this.Controls.Add(this.transactionListBox);
            this.Controls.Add(this.customerListBox);
            this.Controls.Add(this.transactionAddButton);
            this.Controls.Add(this.customerAddButton);
            this.Controls.Add(this.transactionsLabel);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.productsListBox);
            this.Controls.Add(this.productAddButton);
            this.Controls.Add(this.productsLabel);
            this.Controls.Add(this.gamesGroupBox);
            this.Controls.Add(this.platformsGroupBox);
            this.Controls.Add(this.accessoriesGroupBox);
            this.Controls.Add(this.customerGroupBox);
            this.Controls.Add(this.transactionsInfoGroupBox);
            this.Controls.Add(this.itemInfoGroupBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ViradaGames";
            this.Padding = new System.Windows.Forms.Padding(21, 20, 21, 20);
            this.Text = "Virada Games";
            this.Load += new System.EventHandler(this.ViradaGames_Load);
            this.itemInfoGroupBox.ResumeLayout(false);
            this.itemInfoGroupBox.PerformLayout();
            this.gamesGroupBox.ResumeLayout(false);
            this.gamesGroupBox.PerformLayout();
            this.platformsGroupBox.ResumeLayout(false);
            this.platformsGroupBox.PerformLayout();
            this.accessoriesGroupBox.ResumeLayout(false);
            this.accessoriesGroupBox.PerformLayout();
            this.customerGroupBox.ResumeLayout(false);
            this.customerGroupBox.PerformLayout();
            this.transactionsInfoGroupBox.ResumeLayout(false);
            this.transactionsInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox itemInfoGroupBox;
        private GroupBox gamesGroupBox;
        private GroupBox platformsGroupBox;
        private GroupBox accessoriesGroupBox;
        private GroupBox customerGroupBox;
        private GroupBox transactionsInfoGroupBox;
        private TextBox retailPriceItemInfoTextBox;
        private TextBox stockQuantityItemInfoTextBox;
        private TextBox descriptionItemInfoTextBox;
        private TextBox productIDItemInfoTextBox;
        private Label retailPriceItemInfoLabel;
        private Label stockQuantityItemInfoLabel;
        private Label descriptionItemInfoLabel;
        private Label productIDItemInfoLabel;
        private TextBox mediaTypeGamesTextBox;
        private TextBox publisherGamesTextBox;
        private Label mediaTypeGamesLabel;
        private Label publisherGamesLabel;
        private TextBox modelNumberPlatformsTextBox;
        private Label modelNumberPlatformsLabel;
        private TextBox platformTypeAccessoriesTextBox;
        private Label platformTypeAccessoriesLabel;
        private Label productsLabel;
        private Button productAddButton;
        private ListBox productsListBox;
        private Label customerLabel;
        private Label transactionsLabel;
        private Button customerAddButton;
        private Button transactionAddButton;
        private TextBox emailCustomerTextBox;
        private Label customerIDCustomerLabel;
        private TextBox firstNameCustomerTextBox;
        private Label familyNameCustomerLabel;
        private TextBox familyNameCustomerTextBox;
        private Label firstNameCustomerLabel;
        private TextBox CustomerIDCustomerTextBox;
        private Label emailCustomerLabel;
        private TextBox dateTransactionTextBox;
        private Label dateTransactionsLabel;
        private Label customerIDTransactionsLabel;
        private TextBox quantityTransactionTextBox;
        private TextBox customerIDTransactionTextBox;
        private Label quantityTransactionsLabel;
        private ListBox customerListBox;
        private ListBox transactionListBox;
        private TextBox productIDTransactionTextBox;
        private Label productIDTransactionsLabel;
        private TextBox retailPriceTransactionTextBox;
        private Label retailPriceTransactionsLabel;
    }
}

