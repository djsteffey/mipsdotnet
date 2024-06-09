namespace mipsdotnet{
    public class Registers{
        // variables


        // properties
        public UInt32 PC;

        // methods
        public Registers(){
            this.reset(0);
        }

        public void reset(UInt32 pc){
            this.PC = pc;
        }
    }
}