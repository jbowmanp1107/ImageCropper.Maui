﻿using System;
using ImageCropper.Maui;

namespace ImageCropperDemo
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        protected async void OnClickedRectangle(object sender, EventArgs e)
        {
            imageView.Source = null;
            new ImageCropper.Maui.ImageCropper()
            {
                //                PageTitle = "Test Title",
                //                AspectRatioX = 1,
                //                AspectRatioY = 1,
                Success = (imageFile) =>
                {
                    Dispatcher.Dispatch(() =>
                    {
                        imageView.Source = ImageSource.FromFile(imageFile);
                    });
                },
                Faiure = () => {
                    Console.WriteLine("Error capturando la imagen o haciendo crop.");
                }
            }.Show(this);
        }

        private void OnClickedCircle(object sender, EventArgs e)
        {
            imageView.Source = null;
            new ImageCropper.Maui.ImageCropper()
            {
                CropShape = ImageCropper.Maui.ImageCropper.CropShapeType.Oval,
                Success = (imageFile) =>
                {
                    Dispatcher.Dispatch(() =>
                    {
                        imageView.Source = ImageSource.FromFile(imageFile);
                    });
                },
                Faiure = () => {
                    Console.WriteLine("Error capturando la imagen o haciendo crop.");
                }
            }.Show(this);
        }
    }
}