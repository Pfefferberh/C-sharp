using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GameCommand
{
    public partial class Form1 : Form
    {
        List<Unit> units = new List<Unit>();
        List<Unit> team1 = new List<Unit>();
        List<Unit> team2 = new List<Unit>();
        public Form1()
        {
            InitializeComponent();
            units.Add(new Swordsman());
            units.Add(new Archer());
            units.Add(new Wizard());
            AddsDataSource(units, lbAll);
            
        }
        private void cheackAndCreate(List<Unit> unit)
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
        private void Remove(List<Unit> unit, ListBox list)
        {
            foreach (Unit i in this.units)
            {
                if (list.SelectedItem == i)
                    unit.RemoveAt(list.Items.IndexOf(list.SelectedItem));
            }
        }
        private void ClearDataSource(ListBox lb)
        {
            lb.DataSource = null;
            lb.SelectedIndex = -1;
            lb.SelectedItem = null;
        }
        private void AddsDataSource(List<Unit> unit, ListBox lb)
        {
            lb.DataSource = unit;
            lb.DisplayMember = "KindName";
        }
        private void ValueChanged(List<Unit> unit, ListBox lb)
        {
            int temp = int.Parse(numericUpDown1.Value.ToString());
            if (temp == 0)
                unit.Clear();
            else if (temp < unit.Count)
                unit.RemoveRange(temp - 1, unit.Count - temp);
            ClearDataSource(lb);
            AddsDataSource(unit, lb);
        }
        private void btnTo1_Click(object sender, EventArgs e)
        {
            cheackAndCreate(team1);
            ClearDataSource(lbcommand1);
            AddsDataSource(team1, lbcommand1);
        }
        private void btnFrom1_Click(object sender, EventArgs e)
        {
            Remove(team1, lbcommand1);
            ClearDataSource(lbcommand1);
            AddsDataSource(team1, lbcommand1);
        }
        private void btnTo2_Click(object sender, EventArgs e)
        {
            cheackAndCreate(team2);
            ClearDataSource(lbcommand2);
            AddsDataSource(team2, lbcommand2);
        }
        private void btnFrom2_Click(object sender, EventArgs e)
        {
            Remove(team2, lbcommand2);
            ClearDataSource(lbcommand2);
            AddsDataSource(team2, lbcommand2);
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            ValueChanged(team2, lbcommand2);
            ValueChanged(team1, lbcommand1);
        }
    }
}
