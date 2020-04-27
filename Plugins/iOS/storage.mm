extern "C" long _GetFreeSpace()
{
    NSArray *paths = NSSearchPathForDirectoriesInDomains(NSLibraryDirectory, NSUserDomainMask, YES);
    NSDictionary *dict = [[NSFileManager defaultManager] attributesOfFileSystemForPath:[paths lastObject] error:nil];
    if(dict)
    {
        float free = ([[dict objectForKey: NSFileSystemFreeSize] floatValue]);
        return (long)free;
    }
    return 0;
}