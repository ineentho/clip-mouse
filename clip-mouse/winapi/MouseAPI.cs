using clip_mouse.winapi;
using System;

namespace clip_mouse
{
    class MouseAPI
    {
        public static Vector2 GetCursorPos()
        {
            Vector2 pos;
            if (!Invoke.GetCursorPos(out pos))
            {
                throw new InvokeException("GetCursorPos");
            }
            return pos;
        }
    }
}
