﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Storage;


///<summary>
///See <a href="https://core.telegram.org/constructor/storage.filePdf" />
///</summary>
[TlObject(0xae1e508d)]
public sealed class TFilePdf : IFileType
{
    public uint ConstructorId => 0xae1e508d;


    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);

    }

    public void Deserialize(BinaryReader br)
    {

    }
}