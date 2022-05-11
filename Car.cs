class Car : Vehicle, IGasolineEngine {
    private string registrationnumber;
    private string registrationYear;
    private IEngine engine;

    public void Start() {  }
    internal Car() {
        GearBox gearbox = new GearBox();
        Wheel[] wheels = new Wheel[4];
    }
    public Car(string color) {
        GearBox gearbox = new GearBox();
        Wheel[] wheels = new Wheel[4];
    }
    public Car(string color, float size) {
        GearBox gearbox = new GearBox();
        Wheel[] wheels = new Wheel[4];
    }
    public void Inject() {  }
    public void TurnOff() {  }

    internal GearBox gearBox;
    internal Wheel wheel;
}
