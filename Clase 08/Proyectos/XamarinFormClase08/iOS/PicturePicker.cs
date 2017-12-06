﻿using System;
using System.IO;
using System.Threading.Tasks;
using Foundation;
using UIKit;
using Xamarin.Forms;
using XamarinFormClase08.iOS;

[assembly: Dependency(typeof(PicturePicker))]
namespace XamarinFormClase08.iOS
{
	public class PicturePicker : IPickerInterface
	{
		TaskCompletionSource<Stream> taskCompletionSource;
		UIImagePickerController imagePicker;
		public Task<Stream> GetImageStream ()
		{
			 // Create and define UIImagePickerController
            imagePicker = new UIImagePickerController
            {
                SourceType = UIImagePickerControllerSourceType.PhotoLibrary,
                MediaTypes = UIImagePickerController.AvailableMediaTypes(UIImagePickerControllerSourceType.PhotoLibrary)
            };

            // Set event handlers
            imagePicker.FinishedPickingMedia += OnImagePickerFinishedPickingMedia;
            imagePicker.Canceled += OnImagePickerCancelled;

            // Present UIImagePickerController;
            UIWindow window = UIApplication.SharedApplication.KeyWindow;
			var viewController = window.RootViewController;
			viewController.PresentModalViewController(imagePicker, true);

            // Return Task object
            taskCompletionSource = new TaskCompletionSource<Stream>();
            return taskCompletionSource.Task;
        
		}

		void OnImagePickerFinishedPickingMedia (object sender, UIImagePickerMediaPickedEventArgs args)
		{
			UIImage image = args.EditedImage ?? args.OriginalImage;

			if (image != null) {
				// Convert UIImage to .NET Stream object
				NSData data = image.AsJPEG (1);
				Stream stream = data.AsStream ();

				// Set the Stream as the completion of the Task
				taskCompletionSource.SetResult (stream);
			} else {
				taskCompletionSource.SetResult (null);
			}
			imagePicker.DismissModalViewController (true);
		}

		void OnImagePickerCancelled (object sender, EventArgs args)
		{
			taskCompletionSource.SetResult (null);
			imagePicker.DismissModalViewController (true);
		}
	}
}
