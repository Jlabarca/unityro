﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public partial class HC {

    [PacketHandler(HEADER, "HC_NOTIFY_CHARLIST", SIZE, PacketHandlerAttribute.PacketDirection.In)]
    public class NOTIFY_CHARLIST : InPacket {

        public const PacketHeader HEADER = PacketHeader.HC_NOTIFY_CHARLIST;
        public const int SIZE = 6;

        public PacketHeader GetHeader() {
            return HEADER;
        }

        public bool Read(byte[] data) {

            return true;
        }
    }
}
