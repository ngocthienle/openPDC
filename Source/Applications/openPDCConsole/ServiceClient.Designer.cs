﻿//*******************************************************************************************************
//  ServiceClient.Designer.cs
//  Copyright © 2009 - TVA, all rights reserved - Gbtc
//
//  Build Environment: C#, Visual Studio 2008
//  Primary Developer: James R. Carroll
//      Office: PSO TRAN & REL, CHATTANOOGA - MR BK-C
//       Phone: 423/751-4165
//       Email: jrcarrol@tva.gov
//
//  Code Modification History:
//  -----------------------------------------------------------------------------------------------------
//  05/04/2009 - James R. Carroll
//       Generated original version of source code.
//
//*******************************************************************************************************

namespace openPDC
{
    partial class ServiceClient
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
            if (disposing)
            {
                m_clientHelper.Disconnect();
                if (components != null)
                    components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.m_clientHelper = new TVA.Services.ClientHelper(this.components);
            this.m_remotingClient = new TVA.Communication.TcpClient(this.components);
            this.m_errorLogger = new TVA.ErrorManagement.ErrorLogger(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.m_remotingClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_errorLogger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_errorLogger.ErrorLog)).BeginInit();
            // 
            // m_clientHelper
            // 
            this.m_clientHelper.RemotingClient = this.m_remotingClient;
            // 
            // m_remotingClient
            // 
            this.m_remotingClient.ConnectionString = "Server=localhost:8500";
            this.m_remotingClient.Encryption = TVA.Security.Cryptography.CipherStrength.Level6;
            this.m_remotingClient.Handshake = true;
            this.m_remotingClient.PayloadAware = true;
            this.m_remotingClient.PersistSettings = true;
            this.m_remotingClient.SecureSession = true;
            this.m_remotingClient.SettingsCategory = "RemotingClient";
            // 
            // m_errorLogger
            // 
            // 
            // 
            // 
            this.m_errorLogger.ErrorLog.FileName = "RemoteConsole.ErrorLog.txt";
            this.m_errorLogger.LogToEventLog = false;
            this.m_errorLogger.LogToUI = true;
            ((System.ComponentModel.ISupportInitialize)(this.m_remotingClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_errorLogger.ErrorLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_errorLogger)).EndInit();

        }

        #endregion

        private TVA.Services.ClientHelper m_clientHelper;
        private TVA.Communication.TcpClient m_remotingClient;
        private TVA.ErrorManagement.ErrorLogger m_errorLogger;


    }
}
