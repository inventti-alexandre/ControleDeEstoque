﻿using System.ComponentModel;


namespace ControleDeEstoque.Services.WindowsHost
{
    [RunInstaller(true)]
    public partial class Installer : System.Configuration.Install.Installer
    {
        public Installer()
        {
            InitializeComponent();
        }
    }
}
