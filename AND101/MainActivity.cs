using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace AND101
{
    [Activity(Label = "AND101", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        //private int count = 1;
        EditText inputBill;
        Button calculateButton;
        TextView outputTip;
        TextView outputTotal;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            // Exercise 1 
            // Get our button from the layout resource,
            // and attach an event to it
            //Button button = FindViewById<Button>(Resource.Id.myButton);

            //button.Click += delegate
            //{
            //    button.Text = string.Format("{0} clicks!", count++);
            //};

            // Exercise 2 just use Designer and ToolBox

            //Exercise 3
            inputBill = FindViewById<EditText>(Resource.Id.inputBill);
            calculateButton = FindViewById<Button>(Resource.Id.calculateButton);
            outputTip = FindViewById<TextView>(Resource.Id.outputTip);
            outputTotal = FindViewById<TextView>(Resource.Id.outputTotal);

            calculateButton.Click += CalculateButtonOnClick;
        }

        private void CalculateButtonOnClick(object sender, EventArgs eventArgs)
        {
            string text = inputBill.Text;

            double bill;

            if (double.TryParse(text, out bill))
            {

                var tip = bill * 0.15;
                var total = bill + tip;

                outputTip.Text = tip.ToString("C");
                outputTotal.Text = total.ToString("C");
            }
        }
    }
}

