namespace mipsdotnet{
    class CPU{
        // variables
        

        // properties
        public Registers Registers;


        // methods
        public CPU(){
            this.Registers = new Registers();
        }

        public void reset(UInt32 pc){
            this.Registers.reset(pc);
        }
    }
}