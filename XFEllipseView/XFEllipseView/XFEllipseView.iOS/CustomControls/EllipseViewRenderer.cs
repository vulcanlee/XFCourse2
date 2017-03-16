using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using XFEllipseView.CustomControls;
using System.ComponentModel;
using Xamarin.Forms.Platform.iOS;
using CoreGraphics;
using XFEllipseView.iOS.CustomControls;
using Xamarin.Forms;

//�@�w�n�b namespace ���~�A�ŧi�o�� Renderer ���O
[assembly: ExportRenderer(typeof(EllipseView), typeof(EllipseRenderer))]
namespace XFEllipseView.iOS.CustomControls
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
                this.SetNeedsDisplay(); // Force a call to Draw
            }
        }

        /// <summary>
        /// �ϥ� iOS API�A�i��ø�s�X����
        /// </summary>
        /// <param name="rect"></param>
        public override void Draw(CGRect rect)
        {
            using (var context = UIGraphics.GetCurrentContext())
            {
                var path = CGPath.EllipseFromRect(rect);
                context.AddPath(path);
                context.SetFillColor(this.Element.Color.ToCGColor());
                context.DrawPath(CGPathDrawingMode.Fill);
            }
        }
    }
}