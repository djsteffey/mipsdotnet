namespace mipsdotnet{
    class System{
        // variables
        private bool m_running;
        private CPU m_cpu;
        private MMU m_mmu;
        

        // methods
        public System(){
            this.m_running = false;
            this.m_cpu = new CPU();
            this.m_mmu = new MMU();
        }

        public void addMemoryDeviceRam(UInt32 baseAddress, UInt32 size){
            this.m_mmu.addMemoryDevice(baseAddress, new Ram(size));
        }

        public void run(){
            // flag as running
            this.m_running = true;

            // keep on stepping
            while (this.m_running){
                this.step();
            }
        }

        public void reset(UInt32 pc){
            // reset the cpu
            this.m_cpu.reset(pc);
        }

        public void halt(){
            // flag as stop running
            this.m_running = false;
        }

        public void resume(){
            // start running again
            this.run();
        }

        public void step(){
            // fetch instruction from pc address in mmu
            UInt32 instruction = this.m_mmu.readUint32(this.m_cpu.Registers.PC);

            // decode and execute instruction
        }
    }
}