namespace DataStructureAndAlgorithm.Sorting
{
    // Your music player contains n different songs. You want to listen to goal songs (not necessarily different) during your trip. To avoid boredom, you will create a playlist so that:
    //1. Every song is played at least once.
    //2. A song can only be played again if k other songs have been played.
    // Given n, goal, and k, return the number of possible playlists that you can create

    public class MusicPlayer
    {
        private int SongsCount { get;}
        private int PlaylistCount { get; }
        private int DegreeOfFreedom { get; }

        public MusicPlayer(int songsCount, int playlistCount, int degreeOfFreedom)
        {
            SongsCount = songsCount;
            PlaylistCount = playlistCount;
            DegreeOfFreedom = degreeOfFreedom;
        }

        public void MusicPlaylistCount()
        {
            var possiblePlaylistCount = 0;
            var repititionCount = PlaylistCount - SongsCount;

            if (DegreeOfFreedom == 0 && repititionCount > 0)
            {
                // assume one of the songs is the reapeated one.

                // 1. Possible playlists when reapeated the songs won't be consecutive.

                var othersCount = SongsCount - repititionCount;
                var othersOrderingCount = Factorial(othersCount);

                var repeatedsongOptions = 1 + othersCount;

                var factLoopStop = (repeatedsongOptions > repititionCount) ?                                     (repeatedsongOptions - repititionCount) : 0;
                var repeatedSongOrderingCount = Factorial(repeatedsongOptions,factLoopStop);

                var divisor = (repititionCount <= repeatedsongOptions) ? repititionCount : repeatedsongOptions;

                var playList1 =  (othersOrderingCount * repeatedSongOrderingCount) / divisor;

                // 2. Possible playlists when the songs would be consecutive.
                var playList2 = othersOrderingCount * repeatedsongOptions;


                possiblePlaylistCount = (playList1 + playList2) * (othersCount + 1);
            }
            else if(DegreeOfFreedom > 0)
            {
                possiblePlaylistCount = ComputeCount(PlaylistCount,DegreeOfFreedom,SongsCount); 
            }

            Console.WriteLine($"Number of possible playlits is {possiblePlaylistCount}");
        }

        private int ComputeCount(int playlistCount, int degreeOfFreedom,int songsCount)
        {
            var possiblePlaylistCount = 1;
            var loopCount = 0;

            while (playlistCount > 0)
            {
                loopCount++;

                possiblePlaylistCount = possiblePlaylistCount * songsCount;

                if (songsCount != 1)
                {
                    songsCount--;
                }
                playlistCount--;
            }

            return possiblePlaylistCount;
        }

        private int Factorial(int number,int loopStop = 0)
        {
            var product = 1;
            for (int i = number; i > loopStop; i--)
            {
                product = product * i;
            }

            return product;
        }
    }
}
