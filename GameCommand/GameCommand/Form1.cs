using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace GameCommand
{
    public partial class Form1 : Form
    {
        List<Unit> units = new List<Unit>();
        List<Unit> team1 = new List<Unit>();
        List<Unit> team2 = new List<Unit>();
        string NameTeam1 = "Team 1";
        string NameTeam2 = "Team 2";
        public Form1()
        {
            InitializeComponent();
            units.Add(new Swordsman());
            units.Add(new Archer());
            units.Add(new Wizard());
            AddsDataSource(units, lbAll);

            domainUpDownShow.Items.Add(NameTeam1);
            domainUpDownShow.Items.Add(NameTeam2);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            domainUpDownShow.SelectedItem = NameTeam1;
            btnSaveT1.Text = "Save" + NameTeam1;
            btnSaveT2.Text = "Save" + NameTeam2;
        }
        private void AddUnit(List<Unit> unit)
        {
            if (numericUpDown1.Value > unit.Count)
            {
                foreach (Unit i in this.units)
                {
                    if (lbAll.SelectedItem == i)
                        unit.Add(i);
                }
            }
            else
                MessageBox.Show("Team is full");
        }
        private void RemoveUnit(List<Unit> unit, ListBox list)
        {
            foreach (Unit i in this.units)
            {
                if (list.SelectedItem == i)
                    unit.RemoveAt(list.Items.IndexOf(list.SelectedItem));
            }
        }
        private void ValueChanged(List<Unit> unit, ListBox lb)
        {
            int temp = int.Parse(numericUpDown1.Value.ToString());
            if (temp == 0)
                unit.Clear();
            else if (temp < unit.Count)
                unit.RemoveRange(temp - 1, unit.Count - temp);
            HeadCheangeFunc(unit, lb);
        }
        private void ClearDataSource(ListBox lb)
        {
            lb.DataSource = null;
        }
        private void AddsDataSource(List<Unit> unit, ListBox lb)
        {
            lb.DataSource = unit;
            lb.DisplayMember = "KindName";
        }
        private void RefreshLBShow()
        {
            ClearDataSource(lbShowCommand);
            string temp = domainUpDownShow.SelectedItem.ToString();
            if (temp == NameTeam1 && team1.Count > 0)
                AddsDataSource(team1, lbShowCommand);
            else if (temp == NameTeam2 && team2.Count > 0)
                AddsDataSource(team2, lbShowCommand);
        }
        private void SaveToFile(string fileName, List<Unit> unit)
        {
            if (unit.Count > 0)
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Unit>));
                using (Stream stream = new FileStream(fileName + ".xml", FileMode.OpenOrCreate, FileAccess.Write))
                    xml.Serialize(stream, unit);
                MessageBox.Show($"{fileName} Saved!");
            }
            else
                MessageBox.Show($"{fileName} is empty!");
        }
        private void HeadCheangeFunc(List<Unit> unit, ListBox lb)
        {
            ClearDataSource(lb);
            AddsDataSource(unit, lb);
            RefreshLBShow();
        }
        private void btnTo1_Click(object sender, EventArgs e)
        {
            AddUnit(team1);
            HeadCheangeFunc(team1, lbcommand1);
        }
        private void btnFrom1_Click(object sender, EventArgs e)
        {
            RemoveUnit(team1, lbcommand1);
            HeadCheangeFunc(team1, lbcommand1);
        }
        private void btnTo2_Click(object sender, EventArgs e)
        {
            AddUnit(team2);
            HeadCheangeFunc(team2, lbcommand2);
        }
        private void btnFrom2_Click(object sender, EventArgs e)
        {
            RemoveUnit(team2, lbcommand2);
            HeadCheangeFunc(team2, lbcommand2);
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            ValueChanged(team2, lbcommand2);
            ValueChanged(team1, lbcommand1);
        }
        private void domainUpDownShow_SelectedItemChanged(object sender, EventArgs e)
        {
            RefreshLBShow();
        }
        private void btnSaveT1_Click(object sender, EventArgs e)
        {
            SaveToFile(NameTeam1, team1);
        }
        private void btnSaveT2_Click(object sender, EventArgs e)
        {
            SaveToFile(NameTeam2, team2);
        }
    }
}
