using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Exercice03.UserControls;

public partial class ProfileUserControl : UserControl
{



    public string ProfilePic
    {
        get { return (string)GetValue(ProfilePicProperty); }
        set { SetValue(ProfilePicProperty, value); }
    }

    // Using a DependencyProperty as the backing store for ProfilePic.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty ProfilePicProperty =
        DependencyProperty.Register("ProfilePic", typeof(string), typeof(ProfileUserControl), new PropertyMetadata(string.Empty));



    public string FullName
    {
        get { return (string)GetValue(FullNameProperty); }
        set { SetValue(FullNameProperty, value); }
    }

    // Using a DependencyProperty as the backing store for FullName.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty FullNameProperty =
        DependencyProperty.Register("FullName", typeof(string), typeof(ProfileUserControl), new PropertyMetadata(string.Empty));



    public string Email
    {
        get { return (string)GetValue(EmailProperty); }
        set { SetValue(EmailProperty, value); }
    }

    // Using a DependencyProperty as the backing store for Email.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty EmailProperty =
        DependencyProperty.Register("Email", typeof(string), typeof(ProfileUserControl), new PropertyMetadata(string.Empty));




    public ProfileUserControl()
    {
        InitializeComponent();
    }
}
