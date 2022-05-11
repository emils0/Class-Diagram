class Factory {
    public static Vehicle Instance = new Car();

    private Factory() {  }

    public Vehicle Create(int type) {
        return Instance;
    }
}
