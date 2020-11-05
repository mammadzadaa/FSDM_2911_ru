using System;
using System.Collections.Generic;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    //Mediator
    class Form
    {
        private Button button;
        private TextBox textBox;
        private ListBox listBox;

        public Form()
        {
            Initializer();
        }

        private void Initializer()
        {
            button = new Button(this);
            textBox = new TextBox(this);
            listBox = new ListBox(this);

            button.OnButtonClicked += OnButtonClick;
            textBox.OnTextChanged += OnTextChanged;
        }

        public void OnButtonClick()
        {
            listBox.Items.Add(textBox.Text);
        }
        public void OnTextChanged()
        {
            button.Enabled = true;
        }
    }

    abstract class Component
    {
        protected Form form;
        public Component(Form form)
        {
            this.form = form;
        }
    }
    class Button : Component
    {
        public bool Enabled { get; set; } = false;
        public Button(Form form) : base(form) { }
        public event Action OnButtonClicked;
        public void Click()
        {
            if (Enabled)
            {
                OnButtonClicked?.Invoke();
            }
        }
    }

    class TextBox : Component
    {
        public TextBox(Form form) : base(form) { }
        public string Text { get; set; }
        public event Action OnTextChanged;
        public void TextChanged()
        {
            OnTextChanged?.Invoke();
        }
    }

    class ListBox : Component
    {
        public ListBox(Form form) : base(form) { }
        public List<string> Items { get; private set; } = new List<string>();
    }
}
