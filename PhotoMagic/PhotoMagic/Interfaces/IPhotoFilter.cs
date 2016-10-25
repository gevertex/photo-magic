using System;
using Xamarin.Forms;

namespace PhotoMagic
{
    public delegate void ProcessingFinishedDelegate(Image image);

    public interface IPhotoFilter
    {
        bool Apply(Image image);
    }
}
