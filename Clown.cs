using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clown
{
    public partial class Clown : Form
    {
        private int _yValue;
        private readonly int _yIncrement = 30;
        private readonly ApiController _apiController;
        public Clown()
        {
            InitializeComponent();
            _apiController = new ApiController();
            LoadData();
        }

        private void RefreshClick(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            AddLabel("NZD TO USD Exchange Rates");

            var currencyExchangeRate = _apiController.CurrencyExchangeRate();
            string date = currencyExchangeRate.RealTimeCurrencyExchangeRate.LastRefreshed.Split(' ')[0];
            var text = $"{date}: {currencyExchangeRate.RealTimeCurrencyExchangeRate.ExchangeRate}";
            AddLabel(text);

            var fxDaily = _apiController.FXDaily();
            for (int i = 2; i < 7; i++)
            {
                date = GetDateMinusDays(i);
                var stockValuesForDay = fxDaily.FunctionName[date];
                var stockMiddle = double.Parse(stockValuesForDay.high) / 2 + double.Parse(stockValuesForDay.low) / 2;
                text = $"{date}: {stockMiddle}";
                AddLabel(text);
            }

        }

        private void AddLabel(string text)
        {
            var label = new Label { Text = text, Location = CalculateLocation(), Width = 200 };
            Controls.Add(label);
        }

        private string GetDateMinusDays(int days)
        {
            var date = DateTime.Now;
            date = date.AddDays(-days);
            string stringRepresentation = $"{date.Year}-{date.Month}-{date.Day}";
            return stringRepresentation;
        }

        private Point CalculateLocation()
        {
            int output = _yValue;
            _yValue += _yIncrement;
            return new Point(0, output); ;
        }

        private void Clown_Load(object sender, EventArgs e)
        {

        }
    }
}
