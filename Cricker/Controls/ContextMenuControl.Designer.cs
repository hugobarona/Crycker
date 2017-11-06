﻿namespace Cricker.Controls
{
    partial class ContextMenuControl
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
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.providerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitstampToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coinBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitcoincomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bTCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rippleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liteCoinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ethereumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currencyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eURToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uSDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshIntervalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.minToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.minToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.minToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.hToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.startAutomaticallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.priceChangeNotificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.providerToolStripMenuItem,
            this.coinToolStripMenuItem,
            this.currencyToolStripMenuItem,
            this.toolStripSeparator2,
            this.refreshIntervalToolStripMenuItem,
            this.priceChangeNotificationToolStripMenuItem,
            this.toolStripSeparator1,
            this.startAutomaticallyToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.contextMenu.Name = "contextMenuStrip";
            this.contextMenu.Size = new System.Drawing.Size(207, 176);
            // 
            // providerToolStripMenuItem
            // 
            this.providerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bitstampToolStripMenuItem,
            this.coinBaseToolStripMenuItem,
            this.bitcoincomToolStripMenuItem});
            this.providerToolStripMenuItem.Enabled = false;
            this.providerToolStripMenuItem.Name = "providerToolStripMenuItem";
            this.providerToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.providerToolStripMenuItem.Text = "&Provider";
            // 
            // bitstampToolStripMenuItem
            // 
            this.bitstampToolStripMenuItem.Name = "bitstampToolStripMenuItem";
            this.bitstampToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.bitstampToolStripMenuItem.Tag = "Bitstamp";
            this.bitstampToolStripMenuItem.Text = "Bitstamp";
            this.bitstampToolStripMenuItem.Click += new System.EventHandler(this.ProviderClick);
            // 
            // coinBaseToolStripMenuItem
            // 
            this.coinBaseToolStripMenuItem.Name = "coinBaseToolStripMenuItem";
            this.coinBaseToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.coinBaseToolStripMenuItem.Tag = "CoinBase";
            this.coinBaseToolStripMenuItem.Text = "CoinBase";
            this.coinBaseToolStripMenuItem.Click += new System.EventHandler(this.ProviderClick);
            // 
            // bitcoincomToolStripMenuItem
            // 
            this.bitcoincomToolStripMenuItem.Name = "bitcoincomToolStripMenuItem";
            this.bitcoincomToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.bitcoincomToolStripMenuItem.Tag = "Blockchain";
            this.bitcoincomToolStripMenuItem.Text = "Blockchain";
            this.bitcoincomToolStripMenuItem.Click += new System.EventHandler(this.ProviderClick);
            // 
            // coinToolStripMenuItem
            // 
            this.coinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bTCToolStripMenuItem,
            this.rippleToolStripMenuItem,
            this.liteCoinToolStripMenuItem,
            this.ethereumToolStripMenuItem});
            this.coinToolStripMenuItem.Enabled = false;
            this.coinToolStripMenuItem.Name = "coinToolStripMenuItem";
            this.coinToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.coinToolStripMenuItem.Text = "&Coin";
            // 
            // bTCToolStripMenuItem
            // 
            this.bTCToolStripMenuItem.Checked = true;
            this.bTCToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bTCToolStripMenuItem.Name = "bTCToolStripMenuItem";
            this.bTCToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.bTCToolStripMenuItem.Tag = "BTC";
            this.bTCToolStripMenuItem.Text = "BTC";
            this.bTCToolStripMenuItem.Click += new System.EventHandler(this.CoinClick);
            // 
            // rippleToolStripMenuItem
            // 
            this.rippleToolStripMenuItem.Name = "rippleToolStripMenuItem";
            this.rippleToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.rippleToolStripMenuItem.Tag = "XRP";
            this.rippleToolStripMenuItem.Text = "Ripple XRP";
            this.rippleToolStripMenuItem.Click += new System.EventHandler(this.CoinClick);
            // 
            // liteCoinToolStripMenuItem
            // 
            this.liteCoinToolStripMenuItem.Name = "liteCoinToolStripMenuItem";
            this.liteCoinToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.liteCoinToolStripMenuItem.Tag = "LTC";
            this.liteCoinToolStripMenuItem.Text = "Lite Coin";
            this.liteCoinToolStripMenuItem.Click += new System.EventHandler(this.CoinClick);
            // 
            // ethereumToolStripMenuItem
            // 
            this.ethereumToolStripMenuItem.Name = "ethereumToolStripMenuItem";
            this.ethereumToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.ethereumToolStripMenuItem.Tag = "ETH";
            this.ethereumToolStripMenuItem.Text = "Ethereum";
            this.ethereumToolStripMenuItem.Click += new System.EventHandler(this.CoinClick);
            // 
            // currencyToolStripMenuItem
            // 
            this.currencyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eURToolStripMenuItem,
            this.uSDToolStripMenuItem});
            this.currencyToolStripMenuItem.Name = "currencyToolStripMenuItem";
            this.currencyToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.currencyToolStripMenuItem.Text = "Cu&rrency";
            // 
            // eURToolStripMenuItem
            // 
            this.eURToolStripMenuItem.Name = "eURToolStripMenuItem";
            this.eURToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.eURToolStripMenuItem.Tag = "EUR";
            this.eURToolStripMenuItem.Text = "EUR";
            this.eURToolStripMenuItem.Click += new System.EventHandler(this.CurrencyClick);
            // 
            // uSDToolStripMenuItem
            // 
            this.uSDToolStripMenuItem.Name = "uSDToolStripMenuItem";
            this.uSDToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.uSDToolStripMenuItem.Tag = "USD";
            this.uSDToolStripMenuItem.Text = "USD";
            this.uSDToolStripMenuItem.Click += new System.EventHandler(this.CurrencyClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(203, 6);
            // 
            // refreshIntervalToolStripMenuItem
            // 
            this.refreshIntervalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.secToolStripMenuItem,
            this.minToolStripMenuItem,
            this.minToolStripMenuItem1,
            this.minToolStripMenuItem2,
            this.minToolStripMenuItem3,
            this.minToolStripMenuItem4,
            this.hToolStripMenuItem});
            this.refreshIntervalToolStripMenuItem.Name = "refreshIntervalToolStripMenuItem";
            this.refreshIntervalToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.refreshIntervalToolStripMenuItem.Text = "Refresh &Interval";
            // 
            // secToolStripMenuItem
            // 
            this.secToolStripMenuItem.Name = "secToolStripMenuItem";
            this.secToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.secToolStripMenuItem.Tag = "15";
            this.secToolStripMenuItem.Text = "15 sec";
            this.secToolStripMenuItem.Click += new System.EventHandler(this.RefreshIntervalClick);
            // 
            // minToolStripMenuItem
            // 
            this.minToolStripMenuItem.Name = "minToolStripMenuItem";
            this.minToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.minToolStripMenuItem.Tag = "60";
            this.minToolStripMenuItem.Text = "1 min";
            this.minToolStripMenuItem.Click += new System.EventHandler(this.RefreshIntervalClick);
            // 
            // minToolStripMenuItem1
            // 
            this.minToolStripMenuItem1.CheckOnClick = true;
            this.minToolStripMenuItem1.Name = "minToolStripMenuItem1";
            this.minToolStripMenuItem1.Size = new System.Drawing.Size(110, 22);
            this.minToolStripMenuItem1.Tag = "180";
            this.minToolStripMenuItem1.Text = "3 min";
            this.minToolStripMenuItem1.Click += new System.EventHandler(this.RefreshIntervalClick);
            // 
            // minToolStripMenuItem2
            // 
            this.minToolStripMenuItem2.CheckOnClick = true;
            this.minToolStripMenuItem2.Name = "minToolStripMenuItem2";
            this.minToolStripMenuItem2.Size = new System.Drawing.Size(110, 22);
            this.minToolStripMenuItem2.Tag = "300";
            this.minToolStripMenuItem2.Text = "5 min";
            this.minToolStripMenuItem2.Click += new System.EventHandler(this.RefreshIntervalClick);
            // 
            // minToolStripMenuItem3
            // 
            this.minToolStripMenuItem3.CheckOnClick = true;
            this.minToolStripMenuItem3.Name = "minToolStripMenuItem3";
            this.minToolStripMenuItem3.Size = new System.Drawing.Size(110, 22);
            this.minToolStripMenuItem3.Tag = "900";
            this.minToolStripMenuItem3.Text = "15 min";
            this.minToolStripMenuItem3.Click += new System.EventHandler(this.RefreshIntervalClick);
            // 
            // minToolStripMenuItem4
            // 
            this.minToolStripMenuItem4.CheckOnClick = true;
            this.minToolStripMenuItem4.Name = "minToolStripMenuItem4";
            this.minToolStripMenuItem4.Size = new System.Drawing.Size(110, 22);
            this.minToolStripMenuItem4.Tag = "1800";
            this.minToolStripMenuItem4.Text = "30 min";
            this.minToolStripMenuItem4.Click += new System.EventHandler(this.RefreshIntervalClick);
            // 
            // hToolStripMenuItem
            // 
            this.hToolStripMenuItem.CheckOnClick = true;
            this.hToolStripMenuItem.Name = "hToolStripMenuItem";
            this.hToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.hToolStripMenuItem.Tag = "3600";
            this.hToolStripMenuItem.Text = "1 h";
            this.hToolStripMenuItem.Click += new System.EventHandler(this.RefreshIntervalClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(203, 6);
            // 
            // startAutomaticallyToolStripMenuItem
            // 
            this.startAutomaticallyToolStripMenuItem.Enabled = false;
            this.startAutomaticallyToolStripMenuItem.Name = "startAutomaticallyToolStripMenuItem";
            this.startAutomaticallyToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.startAutomaticallyToolStripMenuItem.Text = "Run on Windows startup";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(203, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitClick);
            // 
            // priceChangeNotificationToolStripMenuItem
            // 
            this.priceChangeNotificationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.priceChangeNotificationToolStripMenuItem.Name = "priceChangeNotificationToolStripMenuItem";
            this.priceChangeNotificationToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.priceChangeNotificationToolStripMenuItem.Text = "Price change notification";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem3.Text = "3%";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem4.Text = "5%";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem5.Text = "10%";
            // 
            // ContextMenuControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.contextMenu;
            this.Name = "ContextMenuControl";
            this.Size = new System.Drawing.Size(901, 579);
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem refreshIntervalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem minToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem minToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem minToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem hToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currencyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eURToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uSDToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bTCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rippleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem providerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bitstampToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coinBaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bitcoincomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liteCoinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ethereumToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem startAutomaticallyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem secToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem priceChangeNotificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
    }
}