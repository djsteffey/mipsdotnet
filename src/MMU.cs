namespace mipsdotnet{
    class MMU{
        private class MemoryDeviceEntry{
            public UInt32 BaseAddress;
            public IMemoryDevice Device;

            public MemoryDeviceEntry(UInt32 baseAddress, IMemoryDevice device){
                this.BaseAddress = baseAddress;
                this.Device = device;
            }
        }

        // variables
        private List<MemoryDeviceEntry> m_memoryDeviceList;


        // methods
        public MMU(){
            this.m_memoryDeviceList = new List<MemoryDeviceEntry>();
        }

        public void addMemoryDevice(UInt32 baseAddress, IMemoryDevice memoryDevice){
            this.m_memoryDeviceList.Add(new MemoryDeviceEntry(baseAddress, memoryDevice));
        }

        public byte readUint8(UInt32 address){
            MemoryDeviceEntry entry = this.findMemoryDeviceEntry(address);
            return entry.Device.readUint8(address - entry.BaseAddress);
        }

        public UInt16 readUint16(UInt32 address){
            MemoryDeviceEntry entry = this.findMemoryDeviceEntry(address);
            return entry.Device.readUint16(address - entry.BaseAddress);
        }

        public UInt32 readUint32(UInt32 address){
            MemoryDeviceEntry entry = this.findMemoryDeviceEntry(address);
            return entry.Device.readUint32(address - entry.BaseAddress);
        }

        public void writeUint8(UInt32 address, byte value){
            MemoryDeviceEntry entry = this.findMemoryDeviceEntry(address);
            entry.Device.writeUint8(address - entry.BaseAddress, value);
        }

        public void writeUint16(UInt32 address, UInt16 value){
            MemoryDeviceEntry entry = this.findMemoryDeviceEntry(address);
            entry.Device.writeUint16(address - entry.BaseAddress, value);
        }

        public void writeUint32(UInt32 address, UInt32 value){
            MemoryDeviceEntry entry = this.findMemoryDeviceEntry(address);
            entry.Device.writeUint32(address - entry.BaseAddress, value);
        }

        private MemoryDeviceEntry findMemoryDeviceEntry(UInt32 address){
            foreach (MemoryDeviceEntry entry in this.m_memoryDeviceList){
                if (address >= entry.BaseAddress && address <= entry.BaseAddress + entry.Device.getSize()){
                    return entry;
                }
            }
            return null;
        }
    }
}