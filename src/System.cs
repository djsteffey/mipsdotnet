namespace mipsdotnet{
    class System{
        // variables
        private CPU m_cpu;
        private MMU m_mmu;
        

        // methods
        public System(){
            this.m_cpu = new CPU();
            this.m_mmu = new MMU();
        }

        public void addMemoryDeviceRam(UInt32 baseAddress, UInt32 size){
            this.m_mmu.addMemoryDevice(baseAddress, new Ram(size));
        }

        public void run(){
            
        }

        public void halt(){

        }

        public void reset(){

        }
    }
}