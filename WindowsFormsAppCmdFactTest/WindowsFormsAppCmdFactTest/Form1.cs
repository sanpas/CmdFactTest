using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppCmdFactTest.FactoryCom;
using WindowsFormsAppCmdFactTest.ProtocoleCom;

namespace WindowsFormsAppCmdFactTest
{
    public partial class Form1 : Form
    {
        private ProtocoleCommunicationInfo _protocoleCommunicationInfo;

        private FactoryProtocoleCom _factoryProtocoleCom;

        public Form1()
        {
            _protocoleCommunicationInfo = ProtocoleCommunicationInfo.COMA;
            _factoryProtocoleCom = new FactoryProtocoleCom();
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            //set label current protocole in use
            label1.Text = $"Protocole in use : {_protocoleCommunicationInfo.ToString()}";
            //Load cmbBox
            cmbBoxProtocole.Items.Add(ProtocoleCommunicationInfo.COMA.ToString());
            cmbBoxProtocole.Items.Add(ProtocoleCommunicationInfo.COMB.ToString());
            cmbBoxProtocole.Items.Add(ProtocoleCommunicationInfo.COMC.ToString());
            cmbBoxProtocole.Items.Add(ProtocoleCommunicationInfo.COMD.ToString());
            cmbBoxProtocole.Items.Add(ProtocoleCommunicationInfo.COME.ToString());
            cmbBoxProtocole.SelectedItem = _protocoleCommunicationInfo.ToString();


            //set can use and accesibility to btn
            btnCmdA.Enabled = _factoryProtocoleCom.ProtocoleCommunication(_protocoleCommunicationInfo).CanExecuteCommandA();
            btnCmdB.Enabled = _factoryProtocoleCom.ProtocoleCommunication(_protocoleCommunicationInfo).CanExecuteCommandB();
            btnCmdC.Enabled = _factoryProtocoleCom.ProtocoleCommunication(_protocoleCommunicationInfo).CanExecuteCommandC();
            btnCmdD.Enabled = _factoryProtocoleCom.ProtocoleCommunication(_protocoleCommunicationInfo).CanExecuteCommandD();
            btnCmdE.Enabled = _factoryProtocoleCom.ProtocoleCommunication(_protocoleCommunicationInfo).CanExecuteCommandE();

            btnCmdAll.Enabled = _factoryProtocoleCom.ProtocoleCommunication(_protocoleCommunicationInfo).CanExecuteCommandA() ||
                                _factoryProtocoleCom.ProtocoleCommunication(_protocoleCommunicationInfo).CanExecuteCommandB() ||
                                _factoryProtocoleCom.ProtocoleCommunication(_protocoleCommunicationInfo).CanExecuteCommandC() ||
                                _factoryProtocoleCom.ProtocoleCommunication(_protocoleCommunicationInfo).CanExecuteCommandD() ||
                                _factoryProtocoleCom.ProtocoleCommunication(_protocoleCommunicationInfo).CanExecuteCommandE();
            //Load other data
        }


        public void ReLoadData()
        {
            //set label current protocole in use
            label1.Text = $"Protocole in use : {_protocoleCommunicationInfo.ToString()}";

            //set can use and accesibility to btn
            btnCmdA.Enabled = _factoryProtocoleCom.ProtocoleCommunication(_protocoleCommunicationInfo).CanExecuteCommandA();
            btnCmdB.Enabled = _factoryProtocoleCom.ProtocoleCommunication(_protocoleCommunicationInfo).CanExecuteCommandB();
            btnCmdC.Enabled = _factoryProtocoleCom.ProtocoleCommunication(_protocoleCommunicationInfo).CanExecuteCommandC();
            btnCmdD.Enabled = _factoryProtocoleCom.ProtocoleCommunication(_protocoleCommunicationInfo).CanExecuteCommandD();
            btnCmdE.Enabled = _factoryProtocoleCom.ProtocoleCommunication(_protocoleCommunicationInfo).CanExecuteCommandE();

            btnCmdAll.Enabled = _factoryProtocoleCom.ProtocoleCommunication(_protocoleCommunicationInfo).CanExecuteCommandA() ||
                                _factoryProtocoleCom.ProtocoleCommunication(_protocoleCommunicationInfo).CanExecuteCommandB() ||
                                _factoryProtocoleCom.ProtocoleCommunication(_protocoleCommunicationInfo).CanExecuteCommandC() ||
                                _factoryProtocoleCom.ProtocoleCommunication(_protocoleCommunicationInfo).CanExecuteCommandD() ||
                                _factoryProtocoleCom.ProtocoleCommunication(_protocoleCommunicationInfo).CanExecuteCommandE();
            //Load Other data 
        }

        private void OnCmbBoxProtocoleSelectedIndexChanged(object sender, EventArgs e)
        {
            //send change protocole to distant device 

            //get statut off new protocole Test if change was applied

            //update UI
            _protocoleCommunicationInfo = ProtocoleCommunicationExtensions.GetProtocoleCommunicationValue((string)cmbBoxProtocole.SelectedItem);
            ReLoadData();
        }

        private void OnClickCmdA(object sender, EventArgs e)
        {
            if(_factoryProtocoleCom.ProtocoleCommunication(_protocoleCommunicationInfo).CanExecuteCommandA())
            {
                richTextBox1.Text += _factoryProtocoleCom.ProtocoleCommunication(_protocoleCommunicationInfo).CommandA("paramCmdA");
                richTextBox1.Text += Environment.NewLine;
            }
            else
            {
                MessageBox.Show("Unauthorized CmdA", "Unauthorized CmdA",  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void OnClickCmdB(object sender, EventArgs e)
        {
            if (_factoryProtocoleCom.ProtocoleCommunication(_protocoleCommunicationInfo).CanExecuteCommandB())
            {
                richTextBox1.Text += _factoryProtocoleCom.ProtocoleCommunication(_protocoleCommunicationInfo).CommandB("paramCmdB");
                richTextBox1.Text += Environment.NewLine;
            }
            else
            {
                MessageBox.Show("Unauthorized CmdB", "Unauthorized CmdB", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void OnClickCmdC(object sender, EventArgs e)
        {
            if (_factoryProtocoleCom.ProtocoleCommunication(_protocoleCommunicationInfo).CanExecuteCommandC())
            {
                richTextBox1.Text += _factoryProtocoleCom.ProtocoleCommunication(_protocoleCommunicationInfo).CommandC("paramCmdC");
                richTextBox1.Text += Environment.NewLine;
            }
            else
            {
                MessageBox.Show("Unauthorized CmdC", "Unauthorized CmdC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void OnClickCmdD(object sender, EventArgs e)
        {
            if (_factoryProtocoleCom.ProtocoleCommunication(_protocoleCommunicationInfo).CanExecuteCommandD())
            {
                richTextBox1.Text += _factoryProtocoleCom.ProtocoleCommunication(_protocoleCommunicationInfo).CommandD("paramCmdD");
                richTextBox1.Text += Environment.NewLine;
            }
            else
            {
                MessageBox.Show("Unauthorized CmdD", "Unauthorized CmdD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void OnClickCmdE(object sender, EventArgs e)
        {
            if (_factoryProtocoleCom.ProtocoleCommunication(_protocoleCommunicationInfo).CanExecuteCommandE())
            {
                richTextBox1.Text += _factoryProtocoleCom.ProtocoleCommunication(_protocoleCommunicationInfo).CommandE("paramCmdE");
                richTextBox1.Text += Environment.NewLine;
            }
            else
            {
                MessageBox.Show("Unauthorized CmdE", "Unauthorized CmdE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnClickClear(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
        }

        private void OnClickCmdAll(object sender, EventArgs e)
        {
            if (_factoryProtocoleCom.ProtocoleCommunication(_protocoleCommunicationInfo).CanExecuteCommandA())
            {
                richTextBox1.Text += _factoryProtocoleCom.ProtocoleCommunication(_protocoleCommunicationInfo).CommandA("paramCmdA");
                richTextBox1.Text += Environment.NewLine;
            }
            if (_factoryProtocoleCom.ProtocoleCommunication(_protocoleCommunicationInfo).CanExecuteCommandB())
            {
                richTextBox1.Text += _factoryProtocoleCom.ProtocoleCommunication(_protocoleCommunicationInfo).CommandB("paramCmdB");
                richTextBox1.Text += Environment.NewLine;
            }
            if (_factoryProtocoleCom.ProtocoleCommunication(_protocoleCommunicationInfo).CanExecuteCommandC())
            {
                richTextBox1.Text += _factoryProtocoleCom.ProtocoleCommunication(_protocoleCommunicationInfo).CommandC("paramCmdC");
                richTextBox1.Text += Environment.NewLine;
            }
            if (_factoryProtocoleCom.ProtocoleCommunication(_protocoleCommunicationInfo).CanExecuteCommandD())
            {
                richTextBox1.Text += _factoryProtocoleCom.ProtocoleCommunication(_protocoleCommunicationInfo).CommandD("paramCmdD");
                richTextBox1.Text += Environment.NewLine;
            }
            if (_factoryProtocoleCom.ProtocoleCommunication(_protocoleCommunicationInfo).CanExecuteCommandE())
            {
                richTextBox1.Text += _factoryProtocoleCom.ProtocoleCommunication(_protocoleCommunicationInfo).CommandE("paramCmdE");
                richTextBox1.Text += Environment.NewLine;
            }
        }
    }
}
