# ChangeGridSample  
This repository is for demonstrating dynamic grid resizing with CommunityToolkit.Mvvm  

## Overview  
The main window hosts two tables inside a grid. Four commands are exposed by `MainWindowViewModel` and are bound to buttons:
- **Up** - sets the first row height to **200**.
- **MakeSameHeight** - sets the first row height to **350**.
- **Down** - sets the first row height to **600*.
- **SwitchGrid** - swaps the positions of `table1Grid` and `table2Grid`.

Invoking these commands adjusts the height of the top row or swaps the two inner grids at runtime.
