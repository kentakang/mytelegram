﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/inlineQueryPeerTypeSameBotPM" />
///</summary>
[TlObject(0x3081ed9d)]
public sealed class TInlineQueryPeerTypeSameBotPM : IInlineQueryPeerType
{
    public uint ConstructorId => 0x3081ed9d;


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