using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using UIKit;
using TabbedPageDemo.iOS;

[assembly: ExportRenderer(typeof(TabbedPage), typeof(ExtendedTabbedPageRenderer))]
namespace TabbedPageDemo.iOS
{
	public class ExtendedTabbedPageRenderer : TabbedRenderer
	{
		public override void ViewWillLayoutSubviews()
		{
			UITextAttributes normalTextAttributes = new UITextAttributes();
			normalTextAttributes.Font = UIFont.FromName("Arial", 18.0F);

			foreach (UIViewController vc in ViewControllers)
			{
				//Adjust the title's position   
				vc.TabBarItem.TitlePositionAdjustment = new UIOffset(0, -14);
				vc.TabBarItem.SetTitleTextAttributes(normalTextAttributes, UIControlState.Normal);

				//Adjust the icon's position
				//vc.TabBarItem.ImageInsets = new UIEdgeInsets(-36, 0, 36, 0);
			}
		}
	}
}