
namespace BestPractices.Solid
{
    /*
    ANTES DE APLICAR PRINCIPIO 
    */
    public class LightBulb
    {
        public bool IsOn { get; set; }
        public void TurnOn() {  }
        public void TurnOff() {  }
    }

    public class Switch
    {
        private LightBulb bulb;

        public Switch(LightBulb bulb)
        {
            this.bulb = bulb;
        }

        public void Toggle()
        {
            if (bulb.IsOn)
                bulb.TurnOff();
            else
                bulb.TurnOn();
        }
    }

    /*
    DESPUES DE APLICAR PRINCIPIO 
    */

    public interface ISwitchable
    {
        public bool IsOn { get; set; }
        void TurnOn();
        void TurnOff();
    }

    public class LightBulbInjection : ISwitchable
    {
        public bool IsOn { get; set; }

        public void TurnOff()
        {
            throw new NotImplementedException();
        }

        public void TurnOn()
        {
            throw new NotImplementedException();
        }
    }

    public class SwitchInjection
    {
        private ISwitchable device;

        public SwitchInjection(ISwitchable device)
        {
            this.device = device;
        }

        public void Toggle()
        {
            if (device.IsOn)
                device.TurnOff();
            else
                device.TurnOn();
        }
    }
}
