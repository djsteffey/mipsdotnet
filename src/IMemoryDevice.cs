namespace mipsdotnet{
    interface IMemoryDevice{
        UInt32 getSize();
        byte readUint8(UInt32 address);
        UInt16 readUint16(UInt32 address);
        UInt32 readUint32(UInt32 address);
        void writeUint8(UInt32 address, byte value);
        void writeUint16(UInt32 address, UInt16 value);
        void writeUint32(UInt32 address, UInt32 value);
    }
}