using MauiApp2.Data;
using Microsoft.EntityFrameworkCore.Storage;

namespace MauiApp2
{
    public partial class MainPage : ContentPage
    {
        private readonly DatabaseContext _context;
        public MainPage(DatabaseContext context)
        {
            _context = context;
            InitializeComponent();
            listv.ItemsSource = _context.Zvirata.ToList();
        }

    }

}
