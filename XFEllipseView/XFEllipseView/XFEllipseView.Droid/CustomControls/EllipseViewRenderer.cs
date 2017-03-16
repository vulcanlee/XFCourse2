using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using XFEllipseView.CustomControls;
using Xamarin.Forms.Platform.Android;
using System.ComponentModel;
using Android.Graphics;
using XFEllipseView.Droid.CustomControls;
using Xamarin.Forms;

//�@�w�n�b namespace ���~�A�ŧi�o�� Renderer ���O
[assembly: ExportRenderer(typeof(EllipseView), typeof(EllipseRenderer))]
namespace XFEllipseView.Droid.CustomControls
{
    public class EllipseRenderer : VisualElementRenderer<EllipseView>
    {
        /// <summary>
        /// �o�Ӥ�k�s�b���ت��A�O���F�קK Linker �N�o�����O�P��k�����A�y�����ε{���{�h
        /// ������O?
        /// </summary>
        public static void Init()
        {

        }

        public EllipseRenderer()
        {
            this.SetWillNotDraw(false);
        }

        /// <summary>
        /// ���ݩʦ��ܰʪ��ɭԡA�N�|�b�o�Ӥ�k���i��������ʳB�z
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            // �P�_�O�_���ܧ�o�Ӿ��Ϊ��C��
            if (e.PropertyName == EllipseView.ColorProperty.PropertyName)
            {
                // ����橳�U��k�A�N�|�X�� OnDraw ��k�Q����
                this.Invalidate(); // Force a call to OnDraw
            }
        }

        /// <summary>
        /// �ϥ� Android API�A�i��ø�s�X����
        /// </summary>
        /// <param name="canvas"></param>
        protected override void OnDraw(Canvas canvas)
        {
            var element = this.Element;
            var rect = new Rect();
            this.GetDrawingRect(rect);

            var paint = new Paint()
            {
                Color = element.Color.ToAndroid(),
                AntiAlias = true
            };

            canvas.DrawOval(new RectF(rect), paint);
        }
    }
}