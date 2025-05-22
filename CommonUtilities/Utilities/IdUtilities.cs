using System;

namespace CommonUtilities {
    public static class IdUtilities {
        public static string GenerateId() {
            return $"{Guid.NewGuid()}_{DateTime.UtcNow.Ticks}";
        }
    }
}
