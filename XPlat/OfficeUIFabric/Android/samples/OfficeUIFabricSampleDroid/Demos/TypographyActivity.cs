﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.Widget;
using Android.Views;
using Android.Widget;

namespace OfficeUIFabricSampleDroid.Demos
{
    [Activity]
    public class TypographyActivity : DemoActivity
    {
        protected override int ContentLayoutId => Resource.Layout.activity_typography;

        TextView typography_example_body_2;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            typography_example_body_2 = FindViewById<TextView>(Resource.Id.typography_example_body_2);

            TextViewCompat.SetTextAppearance(typography_example_body_2, Resource.Style.TextAppearance_UIFabric_Body2);
        }
    }
}