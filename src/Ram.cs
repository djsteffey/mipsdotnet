namespace mipsdotnet{
    class Ram : IMemoryDevice{
        // variables
        private UInt32 m_size;
        private byte[] m_data;

        // properties


        // methods
        public Ram(UInt32 size){
            this.m_size = size;
            this.m_data = new byte[this.m_size];
        }
        
        public UInt32 getSize(){
            return this.m_size;
        }

        public byte readUint8(UInt32 address){
            return this.m_data[address];
        }

        public UInt16 readUint16(UInt32 address){
            return (UInt16)(this.m_data[address] << 8 & this.m_data[address + 1]);
        }

        public UInt32 readUint32(UInt32 address){
            return (UInt32)(this.m_data[address] << 24 & this.m_data[address + 1] << 16 & this.m_data[address + 2] << 8 & this.m_data[address + 3]);
        }

        public void writeUint8(UInt32 address, byte value){
            this.m_data[address] = value;
        }

        public void writeUint16(UInt32 address, UInt16 value){
            this.m_data[address] = (byte)(value >> 8 & 0xff);
            this.m_data[address + 1] = (byte)(value & 0xff);
        }

        public void writeUint32(UInt32 address, UInt32 value){
            this.m_data[address] = (byte)(value >> 24 & 0xff);
            this.m_data[address + 1] = (byte)(value >> 16 & 0xff);
            this.m_data[address + 2] = (byte)(value >> 8 & 0xff);
            this.m_data[address + 3] = (byte)(value & 0xff);
        }
    }
}