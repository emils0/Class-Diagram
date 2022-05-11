class Toyota : IGasolineEngine, IBreakable {
    private float capacity;

    public Toyota(float c) {
        capacity = c;
    }

    public void Inject() {  }
    public void Start() {  }
    public void TurnOff() {  }
    public void Brake() {  }
}
