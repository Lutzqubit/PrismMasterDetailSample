using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using PrismMasterDetailSample.Model;
using PrismMasterDetailSample.Resources;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace PrismMasterDetailSample.ViewModels
{
    public class MainMasterDetailPageViewModel : ViewModelBase
    {
        INavigationService _navigationService;
        public ObservableCollection<MasterPageItem> MasterPageItems { get; set; }
        public DelegateCommand<string> NavigateCommand { get; set; }


        public MainMasterDetailPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            NavigateCommand = new DelegateCommand<string>(Navigate);


            MasterPageItems = new ObservableCollection<MasterPageItem>();

            MasterPageItems.Add(
                new MasterPageItem
                {
                    Title = "Auctions",
                    IconSource = "icon_cone",
                    TargetType = "NavAuctions",
                    Color = Colors.MenuItemColor,
                    CommandParameter = "MainNavigationPage/AuctionsPage",
                    Command = NavigateCommand
                }
                );


            MasterPageItems.Add(
                new MasterPageItem
                {
                    Title = "Equipment",
                    IconSource = "icon_equipment",
                    TargetType = "NavEquipments",
                    Color = Colors.MenuItemColor,
                    CommandParameter = "MainNavigationPage/EquipmentPage",
                    Command = NavigateCommand
                }
                );

            MasterPageItems.Add(
                new MasterPageItem
                {
                    Title = "Appraisals",
                    IconSource = "icon_appraisal",
                    TargetType = "NavProfile",
                    Color = Colors.MenuItemColor,
                    CommandParameter = "MainNavigationPage/AppraisalsPage",
                    Command = NavigateCommand
                }
                );

        }


        private void Navigate(string name)
        {
            _navigationService.Navigate(name);
        }
        public override void OnNavigatedFrom(NavigationParameters parameters)
        {
            base.OnNavigatedFrom(parameters);
        }

        public override void OnNavigatedTo(NavigationParameters parameters)
        {
            base.OnNavigatedFrom(parameters);
        }
    }
}
