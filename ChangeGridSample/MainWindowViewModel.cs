using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows;
using System.Windows.Controls;

namespace ChangeGridSample
{
    public partial class MainWindowViewModel : ObservableObject
    {
        [RelayCommand]
        private void Up(Grid listGrid)
        {
            RowDefinition row = listGrid.RowDefinitions[0];
            row.Height = new GridLength(200);
        }

        [RelayCommand]
        private void MakeSameHeight(Grid listGrid)
        {
            RowDefinition row = listGrid.RowDefinitions[0];
            row.Height = new GridLength(350);
        }

        [RelayCommand]
        private void Down(Grid listGrid)
        {
            RowDefinition row = listGrid.RowDefinitions[0];
            row.Height = new GridLength(600);
        }

        [RelayCommand]
        private void SwitchGrid(Grid listGrid)
        {
            Grid table1Grid = (Grid)listGrid.FindName("table1Grid");
            int table1Row = Grid.GetRow(table1Grid);

            Grid table2Grid = (Grid)listGrid.FindName("table2Grid");
            int table2Row = Grid.GetRow(table2Grid);

            Grid.SetRow(table1Grid, table2Row);
            Grid.SetRow(table2Grid, table1Row);
        }
    }
}
