﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
///See <a href="https://core.telegram.org/method/messages.setBotPrecheckoutResults" />
///</summary>
[TlObject(0x9c2dd95)]
public sealed class RequestSetBotPrecheckoutResults : IRequest<IBool>
{
    public uint ConstructorId => 0x9c2dd95;
    public BitArray Flags { get; set; } = new BitArray(32);
    public bool Success { get; set; }
    public long QueryId { get; set; }
    public string? Error { get; set; }

    public void ComputeFlag()
    {
        if (Success) { Flags[1] = true; }
        if (Error != null) { Flags[0] = true; }
    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);
        bw.Write(QueryId);
        if (Flags[0]) { bw.Serialize(Error); }
    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        if (Flags[1]) { Success = true; }
        QueryId = br.ReadInt64();
        if (Flags[0]) { Error = br.Deserialize<string>(); }
    }
}