﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LanguageManager.Views.General
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class View_MasterDetail : MasterDetailPage
	{
		public View_MasterDetail ()
		{
			InitializeComponent ();
		}
	}
}