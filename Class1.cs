using System;
using ElectronicCardSystem;

namespace ElectronicCardSystem
{
    public class UniversalCard : ElectronicCard
    {
        public override string GetFeatures()
        {
            return "Universal Card";
        }
    }

    public class PassportFeature : CardDecorator
    {
        public PassportFeature(ElectronicCard card) : base(card) { }

        public override string GetFeatures()
        {
            return $"{base.GetFeatures()}, Passport";
        }
    }

    public class InsuranceFeature : CardDecorator
    {
        public InsuranceFeature(ElectronicCard card) : base(card) { }

        public override string GetFeatures()
        {
            return $"{base.GetFeatures()}, Insurance";
        }
    }

    public class BankCardFeature : CardDecorator
    {
        public BankCardFeature(ElectronicCard card) : base(card) { }

        public override string GetFeatures()
        {
            return $"{base.GetFeatures()}, Bank Card";
        }
    }

    public class DriverLicenseFeature : CardDecorator
    {
        public DriverLicenseFeature(ElectronicCard card) : base(card) { }

        public override string GetFeatures()
        {
            return $"{base.GetFeatures()}, Driver License";
        }
    }
}
