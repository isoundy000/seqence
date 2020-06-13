﻿using UnityEngine.Timeline.Data;

namespace UnityEngine.Timeline
{
    public class XMarker
    {
        protected XTrack track { get; }

        public MarkData MarkData { get; }

        public MarkType type
        {
            get { return MarkData.type; }
        }

        protected XTimeline timeline
        {
            get { return track.timeline; }
        }

        public XMarker(XTrack track, MarkData markData)
        {
            this.track = track;
            this.MarkData = markData;
        }


        public float time
        {
            get { return MarkData.time; }
            set { MarkData.time = value; }
        }

        public virtual bool reverse
        {
            get { return true; }
        }

        public virtual void OnTriger()
        {
        }

        public virtual void Dispose()
        {
        }
    }
}
