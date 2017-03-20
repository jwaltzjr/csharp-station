using System;
using System.Drawing;
using System.Windows.Forms;

public delegate void Startdelegate();

class EventDemo : Form
{
    public event Startdelegate StartEvent;

    public EventDemo()
    {
        Button clickMe = new Button();

        clickMe.Parent = this;
        clickMe.Text = "Click Me";
        clickMe.Location = new Point(
            (ClientSize.Width - clickMe.Width) / 2,
            (ClientSize.Height - clickMe.Height) / 2
        );

        clickMe.Click += new EventHandler(OnClickMeClicked);
        StartEvent += new Startdelegate(OnStartEvent);

        StartEvent();
    }

    public void OnClickMeClicked(object sender, EventArgs ea)
    {
        MessageBox.Show("You Clicked My Button!");
    }

    public void OnStartEvent()
    {
        MessageBox.Show("I just started!");
    }

    static void Main(string[] args)
    {
        Application.Run(new EventDemo());
    }
}