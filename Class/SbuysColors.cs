using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CarService
{
    public class SbuysColors
    {
        private static Color _main = ColorTranslator.FromHtml("#333333");
        private static Color _text_main = ColorTranslator.FromHtml("#333333");
        private static Color _sub_main = ColorTranslator.FromHtml("#333333");
        private static Color _text_sub_main = ColorTranslator.FromHtml("#333333");
        private static Color _button = ColorTranslator.FromHtml("#333333");
        private static Color _text_button = ColorTranslator.FromHtml("#333333");
        private static Color _bg_main = ColorTranslator.FromHtml("#333333");
        private static Color _text_bg_main = ColorTranslator.FromHtml("#333333");
        private static Color _bg_minor = ColorTranslator.FromHtml("#333333");
        private static Color _text_bg_minor = ColorTranslator.FromHtml("#333333");

        public static Color Main
        {
            get { return _main; }
            set { _main = value; }
        }
        public static Color Text_Main
        {
            get { return _text_main; }
            set { _text_main = value; }
        }
        public static Color Sub_Main
        {
            get { return _sub_main; }
            set { _sub_main = value; }
        }
        public static Color Text_Sub_Main
        {
            get { return _text_sub_main; }
            set { _text_sub_main = value; }
        }
        public static Color Button
        {
            get { return _button; }
            set { _button = value; }
        }
        public static Color Text_Button
        {
            get { return _text_button; }
            set { _text_button = value; }
        }
        public static Color BG_Main
        {
            get { return _bg_main; }
            set { _bg_main = value; }
        }
        public static Color Text_BG_Main
        {
            get { return _text_bg_main; }
            set { _text_bg_main = value; }
        }
        public static Color BG_Minor
        {
            get { return _bg_minor; }
            set { _bg_minor = value; }
        }
        public static Color Text_BG_Minor
        {
            get { return _text_bg_minor; }
            set { _text_bg_minor = value; }
        }
    }

}
