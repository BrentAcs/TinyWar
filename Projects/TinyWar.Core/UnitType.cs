namespace TinyWar.Core
{
   public enum UnitType
   {
      Unknown = 0,
      Armor = 1,
      Infantry = 2,
      MechInfantry = 3,
   }

   public abstract class UnitBase
   {
      public abstract UnitType Type { get; }
      public abstract string Name { get; }
      public int Strength { get; set; }
   }

   public class Armor : UnitBase
   {
      public override UnitType Type => UnitType.Armor;
      public override string Name { get; }
   }

   public class Infantry : UnitBase
   {
      public override UnitType Type => UnitType.Infantry;
      public override string Name { get; }
   }

   public class MechInfantry : UnitBase
   {
      public override UnitType Type => UnitType.MechInfantry;
      public override string Name { get; }
   }
}