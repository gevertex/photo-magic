using System;
using Xamarin.Forms;
namespace PhotoMagic
{
    public delegate void PickPhotoCompleteDelegate(Image image);

    public interface IPhotoPicker
    {
        void PickPhoto(PickPhotoCompleteDelegate callback);
    }
}
