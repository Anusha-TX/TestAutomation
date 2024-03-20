using System;
using System.Collections.Generic;
using System.Data;
using UiPath.CodedWorkflows;
using UiPath.Core;
using UiPath.Core.Activities.Storage;
using UiPath.Mail.Activities.Api;
using UiPath.Orchestrator.Client.Models;
using UiPath.Testing;
using UiPath.Testing.Activities.TestData;
using UiPath.Testing.Activities.TestDataQueues.Enums;
using UiPath.Testing.Enums;
using UiPath.UIAutomationNext.API.Contracts;
using UiPath.UIAutomationNext.API.Models;
using UiPath.UIAutomationNext.Enums;
using UiPath.CodedWorkflows.DescriptorIntegration;

namespace Deluxe_TestAutomationProject
{
    public partial class CodedWorkflow : CodedWorkflowBase
    {
        public CodedWorkflow()
        {
            _ = new System.Type[]{typeof(UiPath.Testing.API.ITestingService), typeof(UiPath.UIAutomationNext.API.Contracts.IUiAutomationAppService), typeof(UiPath.Mail.Activities.Api.IMailService), typeof(UiPath.Core.Activities.API.ISystemService)};
        }

        protected UiPath.Mail.Activities.Api.IMailService mail { get => serviceContainer.Resolve<UiPath.Mail.Activities.Api.IMailService>(); }

        protected UiPath.Core.Activities.API.ISystemService system { get => serviceContainer.Resolve<UiPath.Core.Activities.API.ISystemService>(); }

        protected UiPath.Testing.API.ITestingService testing { get => serviceContainer.Resolve<UiPath.Testing.API.ITestingService>(); }

        protected UiPath.UIAutomationNext.API.Contracts.IUiAutomationAppService uiAutomation { get => serviceContainer.Resolve<UiPath.UIAutomationNext.API.Contracts.IUiAutomationAppService>(); }
    }
}

namespace Deluxe_TestAutomationProject.ObjectRepository
{
    public static class Descriptors
    {
        public static class Deluxe_Payments_Platform
        {
            public static _Implementation._Deluxe_Payments_Platform.__Payments Payments { get; private set; } = new _Implementation._Deluxe_Payments_Platform.__Payments();
        }

        public static class Deluxe_Payments_Platform_1_
        {
        }
    }
}

namespace Deluxe_TestAutomationProject._Implementation
{
    internal class ScreenDescriptorDefinition : IScreenDescriptorDefinition
    {
        public IScreenDescriptor Screen { get; set; }

        public string Reference { get; set; }

        public string DisplayName { get; set; }
    }

    internal class ElementDescriptorDefinition : IElementDescriptorDefinition
    {
        public IScreenDescriptor Screen { get; set; }

        public string Reference { get; set; }

        public string DisplayName { get; set; }

        public IElementDescriptor ParentElement { get; set; }

        public IElementDescriptor Element { get; set; }
    }

    namespace _Deluxe_Payments_Platform._Payments
    {
        public class __Customer_State : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Customer_State(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "sZadA2rqskWykwZwctCNTg/jOxvkyZBPkGZxPu_rS044Q", DisplayName = "Customer State", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Deluxe_Payments_Platform._Payments
    {
        public class __New_Sale_Item_Added : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __New_Sale_Item_Added(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "sZadA2rqskWykwZwctCNTg/HhW7SV7NpkqXTHcRD3FukA", DisplayName = "New Sale Item Added", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Deluxe_Payments_Platform._Payments
    {
        public class __Order_Summary_Page : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Order_Summary_Page(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "sZadA2rqskWykwZwctCNTg/cBh5s7LYt0qeI68OE0EjCw", DisplayName = "Order Summary Page", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Deluxe_Payments_Platform._Payments
    {
        public class __Sale_Item_Tax_Rate : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Sale_Item_Tax_Rate(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "sZadA2rqskWykwZwctCNTg/6kWDzUf1f0aSWfgFuTJ1Vg", DisplayName = "Sale Item Tax Rate", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Deluxe_Payments_Platform
    {
        public class __Payments : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __Payments()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "sZadA2rqskWykwZwctCNTg/6yKtKaEVBUCgVDvqqA9kbg", DisplayName = "Payments", Screen = this};
                Customer_State = new _Implementation._Deluxe_Payments_Platform._Payments.__Customer_State(this, null);
                New_Sale_Item_Added = new _Implementation._Deluxe_Payments_Platform._Payments.__New_Sale_Item_Added(this, null);
                Order_Summary_Page = new _Implementation._Deluxe_Payments_Platform._Payments.__Order_Summary_Page(this, null);
                Sale_Item_Tax_Rate = new _Implementation._Deluxe_Payments_Platform._Payments.__Sale_Item_Tax_Rate(this, null);
            }

            public _Implementation._Deluxe_Payments_Platform._Payments.__Customer_State Customer_State { get; private set; }

            public _Implementation._Deluxe_Payments_Platform._Payments.__New_Sale_Item_Added New_Sale_Item_Added { get; private set; }

            public _Implementation._Deluxe_Payments_Platform._Payments.__Order_Summary_Page Order_Summary_Page { get; private set; }

            public _Implementation._Deluxe_Payments_Platform._Payments.__Sale_Item_Tax_Rate Sale_Item_Tax_Rate { get; private set; }
        }
    }
}