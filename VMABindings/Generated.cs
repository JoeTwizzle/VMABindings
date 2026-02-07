using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static VMASharp.Native.VmaAllocationCreateFlagBits;

namespace VMASharp.Native
{
    public enum VmaAllocatorCreateFlagBits
    {
        VmaAllocatorCreateExternallySynchronizedBit = 0x00000001,
        VmaAllocatorCreateKhrDedicatedAllocationBit = 0x00000002,
        VmaAllocatorCreateKhrBindMemory2Bit = 0x00000004,
        VmaAllocatorCreateExtMemoryBudgetBit = 0x00000008,
        VmaAllocatorCreateAmdDeviceCoherentMemoryBit = 0x00000010,
        VmaAllocatorCreateBufferDeviceAddressBit = 0x00000020,
        VmaAllocatorCreateExtMemoryPriorityBit = 0x00000040,
        VmaAllocatorCreateKhrMaintenance4Bit = 0x00000080,
        VmaAllocatorCreateKhrMaintenance5Bit = 0x00000100,
        VmaAllocatorCreateKhrExternalMemoryWin32Bit = 0x00000200,
        MaxEnum = 0x7FFFFFFF,
    }

    public enum VmaMemoryUsage
    {
        Unknown = 0,
        GpuOnly = 1,
        CpuOnly = 2,
        CpuToGpu = 3,
        GpuToCpu = 4,
        CpuCopy = 5,
        GpuLazilyAllocated = 6,
        Auto = 7,
        AutoPreferDevice = 8,
        AutoPreferHost = 9,
        MaxEnum = 0x7FFFFFFF,
    }

    public enum VmaAllocationCreateFlagBits
    {
        VmaAllocationCreateDedicatedMemoryBit = 0x00000001,
        VmaAllocationCreateNeverAllocateBit = 0x00000002,
        VmaAllocationCreateMappedBit = 0x00000004,
        VmaAllocationCreateUserDataCopyStringBit = 0x00000020,
        VmaAllocationCreateUpperAddressBit = 0x00000040,
        VmaAllocationCreateDontBindBit = 0x00000080,
        VmaAllocationCreateWithinBudgetBit = 0x00000100,
        VmaAllocationCreateCanAliasBit = 0x00000200,
        VmaAllocationCreateHostAccessSequentialWriteBit = 0x00000400,
        VmaAllocationCreateHostAccessRandomBit = 0x00000800,
        VmaAllocationCreateHostAccessAllowTransferInsteadBit = 0x00001000,
        VmaAllocationCreateStrategyMinMemoryBit = 0x00010000,
        VmaAllocationCreateStrategyMinTimeBit = 0x00020000,
        VmaAllocationCreateStrategyMinOffsetBit = 0x00040000,
        VmaAllocationCreateStrategyBestFitBit = VmaAllocationCreateStrategyMinMemoryBit,
        VmaAllocationCreateStrategyFirstFitBit = VmaAllocationCreateStrategyMinTimeBit,
        VmaAllocationCreateStrategyMask = VmaAllocationCreateStrategyMinMemoryBit | VmaAllocationCreateStrategyMinTimeBit | VmaAllocationCreateStrategyMinOffsetBit,
        MaxEnum = 0x7FFFFFFF,
    }

    public enum VmaPoolCreateFlagBits
    {
        VmaPoolCreateIgnoreBufferImageGranularityBit = 0x00000002,
        VmaPoolCreateLinearAlgorithmBit = 0x00000004,
        VmaPoolCreateAlgorithmMask = VmaPoolCreateLinearAlgorithmBit,
        MaxEnum = 0x7FFFFFFF,
    }

    public enum VmaDefragmentationFlagBits
    {
        VmaDefragmentationFlagAlgorithmFastBit = 0x1,
        VmaDefragmentationFlagAlgorithmBalancedBit = 0x2,
        VmaDefragmentationFlagAlgorithmFullBit = 0x4,
        VmaDefragmentationFlagAlgorithmExtensiveBit = 0x8,
        VmaDefragmentationFlagAlgorithmMask = VmaDefragmentationFlagAlgorithmFastBit | VmaDefragmentationFlagAlgorithmBalancedBit | VmaDefragmentationFlagAlgorithmFullBit | VmaDefragmentationFlagAlgorithmExtensiveBit,
        MaxEnum = 0x7FFFFFFF,
    }

    public enum VmaDefragmentationMoveOperation
    {
        Copy = 0,
        Ignore = 1,
        Destroy = 2,
    }

    public enum VmaVirtualBlockCreateFlagBits
    {
        VmaVirtualBlockCreateLinearAlgorithmBit = 0x00000001,
        VmaVirtualBlockCreateAlgorithmMask = VmaVirtualBlockCreateLinearAlgorithmBit,
        MaxEnum = 0x7FFFFFFF,
    }

    public enum VmaVirtualAllocationCreateFlagBits
    {
        VmaVirtualAllocationCreateUpperAddressBit = VmaAllocationCreateUpperAddressBit,
        VmaVirtualAllocationCreateStrategyMinMemoryBit = VmaAllocationCreateStrategyMinMemoryBit,
        VmaVirtualAllocationCreateStrategyMinTimeBit = VmaAllocationCreateStrategyMinTimeBit,
        VmaVirtualAllocationCreateStrategyMinOffsetBit = VmaAllocationCreateStrategyMinOffsetBit,
        VmaVirtualAllocationCreateStrategyMask = VmaAllocationCreateStrategyMask,
        MaxEnum = 0x7FFFFFFF,
    }

    public partial struct VmaAllocator
    {
    }

    public partial struct VmaPool
    {
    }

    public partial struct VmaAllocation
    {
    }

    public partial struct VmaDefragmentationContext
    {
    }

    public partial struct VmaVirtualAllocation
    {
    }

    public partial struct VmaVirtualBlock
    {
    }

    public unsafe partial struct VmaDeviceMemoryCallbacks
    {
        [NativeTypeName("PFN_vmaAllocateDeviceMemoryFunction _Nullable")]
        public delegate* unmanaged<VmaAllocator, uint, VkDeviceMemory, ulong, void*, void> pfnAllocate;

        [NativeTypeName("PFN_vmaFreeDeviceMemoryFunction _Nullable")]
        public delegate* unmanaged<VmaAllocator, uint, VkDeviceMemory, ulong, void*, void> pfnFree;

        [NativeTypeName("void * _Nullable")]
        public void* pUserData;
    }

    public unsafe partial struct VmaVulkanFunctions
    {
        [NativeTypeName("PFN_vkGetInstanceProcAddr _Nullable")]
        public delegate* unmanaged<VkInstance, byte*, IntPtr> vkGetInstanceProcAddr;

        [NativeTypeName("PFN_vkGetDeviceProcAddr _Nullable")]
        public delegate* unmanaged<VkDevice, byte*, IntPtr> vkGetDeviceProcAddr;

        [NativeTypeName("PFN_vkGetPhysicalDeviceProperties _Nullable")]
        public delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceProperties*, void> vkGetPhysicalDeviceProperties;

        [NativeTypeName("PFN_vkGetPhysicalDeviceMemoryProperties _Nullable")]
        public delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceMemoryProperties*, void> vkGetPhysicalDeviceMemoryProperties;

        [NativeTypeName("PFN_vkAllocateMemory _Nullable")]
        public delegate* unmanaged<VkDevice, VkMemoryAllocateInfo*, VkAllocationCallbacks*, VkDeviceMemory*, VkResult> vkAllocateMemory;

        [NativeTypeName("PFN_vkFreeMemory _Nullable")]
        public delegate* unmanaged<VkDevice, VkDeviceMemory, VkAllocationCallbacks*, void> vkFreeMemory;

        [NativeTypeName("PFN_vkMapMemory _Nullable")]
        public delegate* unmanaged<VkDevice, VkDeviceMemory, ulong, ulong, VkMemoryMapFlagBits, void**, VkResult> vkMapMemory;

        [NativeTypeName("PFN_vkUnmapMemory _Nullable")]
        public delegate* unmanaged<VkDevice, VkDeviceMemory, void> vkUnmapMemory;

        [NativeTypeName("PFN_vkFlushMappedMemoryRanges _Nullable")]
        public delegate* unmanaged<VkDevice, uint, VkMappedMemoryRange*, VkResult> vkFlushMappedMemoryRanges;

        [NativeTypeName("PFN_vkInvalidateMappedMemoryRanges _Nullable")]
        public delegate* unmanaged<VkDevice, uint, VkMappedMemoryRange*, VkResult> vkInvalidateMappedMemoryRanges;

        [NativeTypeName("PFN_vkBindBufferMemory _Nullable")]
        public delegate* unmanaged<VkDevice, VkBuffer, VkDeviceMemory, ulong, VkResult> vkBindBufferMemory;

        [NativeTypeName("PFN_vkBindImageMemory _Nullable")]
        public delegate* unmanaged<VkDevice, VkImage, VkDeviceMemory, ulong, VkResult> vkBindImageMemory;

        [NativeTypeName("PFN_vkGetBufferMemoryRequirements _Nullable")]
        public delegate* unmanaged<VkDevice, VkBuffer, VkMemoryRequirements*, void> vkGetBufferMemoryRequirements;

        [NativeTypeName("PFN_vkGetImageMemoryRequirements _Nullable")]
        public delegate* unmanaged<VkDevice, VkImage, VkMemoryRequirements*, void> vkGetImageMemoryRequirements;

        [NativeTypeName("PFN_vkCreateBuffer _Nullable")]
        public delegate* unmanaged<VkDevice, VkBufferCreateInfo*, VkAllocationCallbacks*, VkBuffer*, VkResult> vkCreateBuffer;

        [NativeTypeName("PFN_vkDestroyBuffer _Nullable")]
        public delegate* unmanaged<VkDevice, VkBuffer, VkAllocationCallbacks*, void> vkDestroyBuffer;

        [NativeTypeName("PFN_vkCreateImage _Nullable")]
        public delegate* unmanaged<VkDevice, VkImageCreateInfo*, VkAllocationCallbacks*, VkImage*, VkResult> vkCreateImage;

        [NativeTypeName("PFN_vkDestroyImage _Nullable")]
        public delegate* unmanaged<VkDevice, VkImage, VkAllocationCallbacks*, void> vkDestroyImage;

        [NativeTypeName("PFN_vkCmdCopyBuffer _Nullable")]
        public delegate* unmanaged<VkCommandBuffer, VkBuffer, VkBuffer, uint, VkBufferCopy*, void> vkCmdCopyBuffer;

        [NativeTypeName("PFN_vkGetBufferMemoryRequirements2KHR _Nullable")]
        public delegate* unmanaged<VkDevice, VkBufferMemoryRequirementsInfo2*, VkMemoryRequirements2*, void> vkGetBufferMemoryRequirements2KHR;

        [NativeTypeName("PFN_vkGetImageMemoryRequirements2KHR _Nullable")]
        public delegate* unmanaged<VkDevice, VkImageMemoryRequirementsInfo2*, VkMemoryRequirements2*, void> vkGetImageMemoryRequirements2KHR;

        [NativeTypeName("PFN_vkBindBufferMemory2KHR _Nullable")]
        public delegate* unmanaged<VkDevice, uint, VkBindBufferMemoryInfo*, VkResult> vkBindBufferMemory2KHR;

        [NativeTypeName("PFN_vkBindImageMemory2KHR _Nullable")]
        public delegate* unmanaged<VkDevice, uint, VkBindImageMemoryInfo*, VkResult> vkBindImageMemory2KHR;

        [NativeTypeName("PFN_vkGetPhysicalDeviceMemoryProperties2KHR _Nullable")]
        public delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceMemoryProperties2*, void> vkGetPhysicalDeviceMemoryProperties2KHR;

        [NativeTypeName("PFN_vkGetDeviceBufferMemoryRequirementsKHR _Nullable")]
        public delegate* unmanaged<VkDevice, VkDeviceBufferMemoryRequirements*, VkMemoryRequirements2*, void> vkGetDeviceBufferMemoryRequirements;

        [NativeTypeName("PFN_vkGetDeviceImageMemoryRequirementsKHR _Nullable")]
        public delegate* unmanaged<VkDevice, VkDeviceImageMemoryRequirements*, VkMemoryRequirements2*, void> vkGetDeviceImageMemoryRequirements;

        [NativeTypeName("void * _Nullable")]
        public void* vkGetMemoryWin32HandleKHR;
    }

    public unsafe partial struct VmaAllocatorCreateInfo
    {
        [NativeTypeName("VmaAllocatorCreateFlags")]
        public uint flags;

        [NativeTypeName("VkPhysicalDevice _Nonnull")]
        public VkPhysicalDevice physicalDevice;

        [NativeTypeName("VkDevice _Nonnull")]
        public VkDevice device;

        [NativeTypeName("VkDeviceSize")]
        public ulong preferredLargeHeapBlockSize;

        [NativeTypeName("const VkAllocationCallbacks * _Nullable")]
        public VkAllocationCallbacks* pAllocationCallbacks;

        [NativeTypeName("const VmaDeviceMemoryCallbacks * _Nullable")]
        public VmaDeviceMemoryCallbacks* pDeviceMemoryCallbacks;

        [NativeTypeName("const VkDeviceSize * _Nullable")]
        public ulong* pHeapSizeLimit;

        [NativeTypeName("const VmaVulkanFunctions * _Nullable")]
        public VmaVulkanFunctions* pVulkanFunctions;

        [NativeTypeName("VkInstance _Nonnull")]
        public VkInstance instance;

        [NativeTypeName("uint32_t")]
        public uint vulkanApiVersion;

        [NativeTypeName("const VkExternalMemoryHandleTypeFlagsKHR * _Nullable")]
        public uint* pTypeExternalMemoryHandleTypes;
    }

    public partial struct VmaAllocatorInfo
    {
        [NativeTypeName("VkInstance _Nonnull")]
        public VkInstance instance;

        [NativeTypeName("VkPhysicalDevice _Nonnull")]
        public VkPhysicalDevice physicalDevice;

        [NativeTypeName("VkDevice _Nonnull")]
        public VkDevice device;
    }

    public partial struct VmaStatistics
    {
        [NativeTypeName("uint32_t")]
        public uint blockCount;

        [NativeTypeName("uint32_t")]
        public uint allocationCount;

        [NativeTypeName("VkDeviceSize")]
        public ulong blockBytes;

        [NativeTypeName("VkDeviceSize")]
        public ulong allocationBytes;
    }

    public partial struct VmaDetailedStatistics
    {
        public VmaStatistics statistics;

        [NativeTypeName("uint32_t")]
        public uint unusedRangeCount;

        [NativeTypeName("VkDeviceSize")]
        public ulong allocationSizeMin;

        [NativeTypeName("VkDeviceSize")]
        public ulong allocationSizeMax;

        [NativeTypeName("VkDeviceSize")]
        public ulong unusedRangeSizeMin;

        [NativeTypeName("VkDeviceSize")]
        public ulong unusedRangeSizeMax;
    }

    public partial struct VmaTotalStatistics
    {
        [NativeTypeName("VmaDetailedStatistics[32]")]
        public _memoryType_e__FixedBuffer memoryType;

        [NativeTypeName("VmaDetailedStatistics[16]")]
        public _memoryHeap_e__FixedBuffer memoryHeap;

        public VmaDetailedStatistics total;

        [InlineArray(32)]
        public partial struct _memoryType_e__FixedBuffer
        {
            public VmaDetailedStatistics e0;
        }

        [InlineArray(16)]
        public partial struct _memoryHeap_e__FixedBuffer
        {
            public VmaDetailedStatistics e0;
        }
    }

    public partial struct VmaBudget
    {
        public VmaStatistics statistics;

        [NativeTypeName("VkDeviceSize")]
        public ulong usage;

        [NativeTypeName("VkDeviceSize")]
        public ulong budget;
    }

    public unsafe partial struct VmaAllocationCreateInfo
    {
        [NativeTypeName("VmaAllocationCreateFlags")]
        public uint flags;

        public VmaMemoryUsage usage;

        [NativeTypeName("VkMemoryPropertyFlags")]
        public uint requiredFlags;

        [NativeTypeName("VkMemoryPropertyFlags")]
        public uint preferredFlags;

        [NativeTypeName("uint32_t")]
        public uint memoryTypeBits;

        [NativeTypeName("VmaPool _Nullable")]
        public VmaPool pool;

        [NativeTypeName("void * _Nullable")]
        public void* pUserData;

        public float priority;
    }

    public unsafe partial struct VmaPoolCreateInfo
    {
        [NativeTypeName("uint32_t")]
        public uint memoryTypeIndex;

        [NativeTypeName("VmaPoolCreateFlags")]
        public uint flags;

        [NativeTypeName("VkDeviceSize")]
        public ulong blockSize;

        [NativeTypeName("size_t")]
        public nuint minBlockCount;

        [NativeTypeName("size_t")]
        public nuint maxBlockCount;

        public float priority;

        [NativeTypeName("VkDeviceSize")]
        public ulong minAllocationAlignment;

        [NativeTypeName("void * _Nullable")]
        public void* pMemoryAllocateNext;
    }

    public unsafe partial struct VmaAllocationInfo
    {
        [NativeTypeName("uint32_t")]
        public uint memoryType;

        [NativeTypeName("VkDeviceMemory _Nullable")]
        public VkDeviceMemory deviceMemory;

        [NativeTypeName("VkDeviceSize")]
        public ulong offset;

        [NativeTypeName("VkDeviceSize")]
        public ulong size;

        [NativeTypeName("void * _Nullable")]
        public void* pMappedData;

        [NativeTypeName("void * _Nullable")]
        public void* pUserData;

        [NativeTypeName("const char * _Nullable")]
        public byte* pName;
    }

    public partial struct VmaAllocationInfo2
    {
        public VmaAllocationInfo allocationInfo;

        [NativeTypeName("VkDeviceSize")]
        public ulong blockSize;

        [NativeTypeName("VkBool32")]
        public uint dedicatedMemory;
    }

    public unsafe partial struct VmaDefragmentationInfo
    {
        [NativeTypeName("VmaDefragmentationFlags")]
        public uint flags;

        [NativeTypeName("VmaPool _Nullable")]
        public VmaPool pool;

        [NativeTypeName("VkDeviceSize")]
        public ulong maxBytesPerPass;

        [NativeTypeName("uint32_t")]
        public uint maxAllocationsPerPass;

        [NativeTypeName("PFN_vmaCheckDefragmentationBreakFunction _Nullable")]
        public delegate* unmanaged<void*, uint> pfnBreakCallback;

        [NativeTypeName("void * _Nullable")]
        public void* pBreakCallbackUserData;
    }

    public partial struct VmaDefragmentationMove
    {
        public VmaDefragmentationMoveOperation operation;

        [NativeTypeName("VmaAllocation _Nonnull")]
        public VmaAllocation srcAllocation;

        [NativeTypeName("VmaAllocation _Nonnull")]
        public VmaAllocation dstTmpAllocation;
    }

    public unsafe partial struct VmaDefragmentationPassMoveInfo
    {
        [NativeTypeName("uint32_t")]
        public uint moveCount;

        [NativeTypeName("VmaDefragmentationMove * _Nullable")]
        public VmaDefragmentationMove* pMoves;
    }

    public partial struct VmaDefragmentationStats
    {
        [NativeTypeName("VkDeviceSize")]
        public ulong bytesMoved;

        [NativeTypeName("VkDeviceSize")]
        public ulong bytesFreed;

        [NativeTypeName("uint32_t")]
        public uint allocationsMoved;

        [NativeTypeName("uint32_t")]
        public uint deviceMemoryBlocksFreed;
    }

    public unsafe partial struct VmaVirtualBlockCreateInfo
    {
        [NativeTypeName("VkDeviceSize")]
        public ulong size;

        [NativeTypeName("VmaVirtualBlockCreateFlags")]
        public uint flags;

        [NativeTypeName("const VkAllocationCallbacks * _Nullable")]
        public VkAllocationCallbacks* pAllocationCallbacks;
    }

    public unsafe partial struct VmaVirtualAllocationCreateInfo
    {
        [NativeTypeName("VkDeviceSize")]
        public ulong size;

        [NativeTypeName("VkDeviceSize")]
        public ulong alignment;

        [NativeTypeName("VmaVirtualAllocationCreateFlags")]
        public uint flags;

        [NativeTypeName("void * _Nullable")]
        public void* pUserData;
    }

    public unsafe partial struct VmaVirtualAllocationInfo
    {
        [NativeTypeName("VkDeviceSize")]
        public ulong offset;

        [NativeTypeName("VkDeviceSize")]
        public ulong size;

        [NativeTypeName("void * _Nullable")]
        public void* pUserData;
    }

    public static unsafe partial class VmaNative
    {
        [DllImport("vma", EntryPoint = "vmaCreateAllocator", ExactSpelling = true)]
        public static extern VkResult CreateAllocator([NativeTypeName("const VmaAllocatorCreateInfo * _Nonnull")] VmaAllocatorCreateInfo* pCreateInfo, [NativeTypeName("VmaAllocator  _Nullable * _Nonnull")] VmaAllocator* pAllocator);

        [DllImport("vma", EntryPoint = "vmaDestroyAllocator", ExactSpelling = true)]
        public static extern void DestroyAllocator([NativeTypeName("VmaAllocator _Nullable")] VmaAllocator allocator);

        [DllImport("vma", EntryPoint = "vmaGetAllocatorInfo", ExactSpelling = true)]
        public static extern void GetAllocatorInfo([NativeTypeName("VmaAllocator _Nonnull")] VmaAllocator allocator, [NativeTypeName("VmaAllocatorInfo * _Nonnull")] VmaAllocatorInfo* pAllocatorInfo);

        [DllImport("vma", EntryPoint = "vmaGetPhysicalDeviceProperties", ExactSpelling = true)]
        public static extern void GetPhysicalDeviceProperties([NativeTypeName("VmaAllocator _Nonnull")] VmaAllocator allocator, [NativeTypeName("const VkPhysicalDeviceProperties * _Nullable * _Nonnull")] VkPhysicalDeviceProperties** ppPhysicalDeviceProperties);

        [DllImport("vma", EntryPoint = "vmaGetMemoryProperties", ExactSpelling = true)]
        public static extern void GetMemoryProperties([NativeTypeName("VmaAllocator _Nonnull")] VmaAllocator allocator, [NativeTypeName("const VkPhysicalDeviceMemoryProperties * _Nullable * _Nonnull")] VkPhysicalDeviceMemoryProperties** ppPhysicalDeviceMemoryProperties);

        [DllImport("vma", EntryPoint = "vmaGetMemoryTypeProperties", ExactSpelling = true)]
        public static extern void GetMemoryTypeProperties([NativeTypeName("VmaAllocator _Nonnull")] VmaAllocator allocator, [NativeTypeName("uint32_t")] uint memoryTypeIndex, [NativeTypeName("VkMemoryPropertyFlags * _Nonnull")] uint* pFlags);

        [DllImport("vma", EntryPoint = "vmaSetCurrentFrameIndex", ExactSpelling = true)]
        public static extern void SetCurrentFrameIndex([NativeTypeName("VmaAllocator _Nonnull")] VmaAllocator allocator, [NativeTypeName("uint32_t")] uint frameIndex);

        [DllImport("vma", EntryPoint = "vmaCalculateStatistics", ExactSpelling = true)]
        public static extern void CalculateStatistics([NativeTypeName("VmaAllocator _Nonnull")] VmaAllocator allocator, [NativeTypeName("VmaTotalStatistics * _Nonnull")] VmaTotalStatistics* pStats);

        [DllImport("vma", EntryPoint = "vmaGetHeapBudgets", ExactSpelling = true)]
        public static extern void GetHeapBudgets([NativeTypeName("VmaAllocator _Nonnull")] VmaAllocator allocator, [NativeTypeName("VmaBudget * _Nonnull")] VmaBudget* pBudgets);

        [DllImport("vma", EntryPoint = "vmaFindMemoryTypeIndex", ExactSpelling = true)]
        public static extern VkResult FindMemoryTypeIndex([NativeTypeName("VmaAllocator _Nonnull")] VmaAllocator allocator, [NativeTypeName("uint32_t")] uint memoryTypeBits, [NativeTypeName("const VmaAllocationCreateInfo * _Nonnull")] VmaAllocationCreateInfo* pAllocationCreateInfo, [NativeTypeName("uint32_t * _Nonnull")] uint* pMemoryTypeIndex);

        [DllImport("vma", EntryPoint = "vmaFindMemoryTypeIndexForBufferInfo", ExactSpelling = true)]
        public static extern VkResult FindMemoryTypeIndexForBufferInfo([NativeTypeName("VmaAllocator _Nonnull")] VmaAllocator allocator, [NativeTypeName("const VkBufferCreateInfo * _Nonnull")] VkBufferCreateInfo* pBufferCreateInfo, [NativeTypeName("const VmaAllocationCreateInfo * _Nonnull")] VmaAllocationCreateInfo* pAllocationCreateInfo, [NativeTypeName("uint32_t * _Nonnull")] uint* pMemoryTypeIndex);

        [DllImport("vma", EntryPoint = "vmaFindMemoryTypeIndexForImageInfo", ExactSpelling = true)]
        public static extern VkResult FindMemoryTypeIndexForImageInfo([NativeTypeName("VmaAllocator _Nonnull")] VmaAllocator allocator, [NativeTypeName("const VkImageCreateInfo * _Nonnull")] VkImageCreateInfo* pImageCreateInfo, [NativeTypeName("const VmaAllocationCreateInfo * _Nonnull")] VmaAllocationCreateInfo* pAllocationCreateInfo, [NativeTypeName("uint32_t * _Nonnull")] uint* pMemoryTypeIndex);

        [DllImport("vma", EntryPoint = "vmaCreatePool", ExactSpelling = true)]
        public static extern VkResult CreatePool([NativeTypeName("VmaAllocator _Nonnull")] VmaAllocator allocator, [NativeTypeName("const VmaPoolCreateInfo * _Nonnull")] VmaPoolCreateInfo* pCreateInfo, [NativeTypeName("VmaPool  _Nullable * _Nonnull")] VmaPool* pPool);

        [DllImport("vma", EntryPoint = "vmaDestroyPool", ExactSpelling = true)]
        public static extern void DestroyPool([NativeTypeName("VmaAllocator _Nonnull")] VmaAllocator allocator, [NativeTypeName("VmaPool _Nullable")] VmaPool pool);

        [DllImport("vma", EntryPoint = "vmaGetPoolStatistics", ExactSpelling = true)]
        public static extern void GetPoolStatistics([NativeTypeName("VmaAllocator _Nonnull")] VmaAllocator allocator, [NativeTypeName("VmaPool _Nonnull")] VmaPool pool, [NativeTypeName("VmaStatistics * _Nonnull")] VmaStatistics* pPoolStats);

        [DllImport("vma", EntryPoint = "vmaCalculatePoolStatistics", ExactSpelling = true)]
        public static extern void CalculatePoolStatistics([NativeTypeName("VmaAllocator _Nonnull")] VmaAllocator allocator, [NativeTypeName("VmaPool _Nonnull")] VmaPool pool, [NativeTypeName("VmaDetailedStatistics * _Nonnull")] VmaDetailedStatistics* pPoolStats);

        [DllImport("vma", EntryPoint = "vmaCheckPoolCorruption", ExactSpelling = true)]
        public static extern VkResult CheckPoolCorruption([NativeTypeName("VmaAllocator _Nonnull")] VmaAllocator allocator, [NativeTypeName("VmaPool _Nonnull")] VmaPool pool);

        [DllImport("vma", EntryPoint = "vmaGetPoolName", ExactSpelling = true)]
        public static extern void GetPoolName([NativeTypeName("VmaAllocator _Nonnull")] VmaAllocator allocator, [NativeTypeName("VmaPool _Nonnull")] VmaPool pool, [NativeTypeName("const char * _Nullable * _Nonnull")] byte** ppName);

        [DllImport("vma", EntryPoint = "vmaSetPoolName", ExactSpelling = true)]
        public static extern void SetPoolName([NativeTypeName("VmaAllocator _Nonnull")] VmaAllocator allocator, [NativeTypeName("VmaPool _Nonnull")] VmaPool pool, [NativeTypeName("const char * _Nullable")] byte* pName);

        [DllImport("vma", EntryPoint = "vmaAllocateMemory", ExactSpelling = true)]
        public static extern VkResult AllocateMemory([NativeTypeName("VmaAllocator _Nonnull")] VmaAllocator allocator, [NativeTypeName("const VkMemoryRequirements * _Nonnull")] VkMemoryRequirements* pVkMemoryRequirements, [NativeTypeName("const VmaAllocationCreateInfo * _Nonnull")] VmaAllocationCreateInfo* pCreateInfo, [NativeTypeName("VmaAllocation  _Nullable * _Nonnull")] VmaAllocation* pAllocation, [NativeTypeName("VmaAllocationInfo * _Nullable")] VmaAllocationInfo* pAllocationInfo);

        [DllImport("vma", EntryPoint = "vmaAllocateDedicatedMemory", ExactSpelling = true)]
        public static extern VkResult AllocateDedicatedMemory([NativeTypeName("VmaAllocator _Nonnull")] VmaAllocator allocator, [NativeTypeName("const VkMemoryRequirements * _Nonnull")] VkMemoryRequirements* pVkMemoryRequirements, [NativeTypeName("const VmaAllocationCreateInfo * _Nonnull")] VmaAllocationCreateInfo* pCreateInfo, [NativeTypeName("void * _Nullable")] void* pMemoryAllocateNext, [NativeTypeName("VmaAllocation  _Nullable * _Nonnull")] VmaAllocation* pAllocation, [NativeTypeName("VmaAllocationInfo * _Nullable")] VmaAllocationInfo* pAllocationInfo);

        [DllImport("vma", EntryPoint = "vmaAllocateMemoryPages", ExactSpelling = true)]
        public static extern VkResult AllocateMemoryPages([NativeTypeName("VmaAllocator _Nonnull")] VmaAllocator allocator, [NativeTypeName("const VkMemoryRequirements * _Nonnull")] VkMemoryRequirements* pVkMemoryRequirements, [NativeTypeName("const VmaAllocationCreateInfo * _Nonnull")] VmaAllocationCreateInfo* pCreateInfo, [NativeTypeName("size_t")] nuint allocationCount, [NativeTypeName("VmaAllocation  _Nullable * _Nonnull")] VmaAllocation* pAllocations, [NativeTypeName("VmaAllocationInfo * _Nullable")] VmaAllocationInfo* pAllocationInfo);

        [DllImport("vma", EntryPoint = "vmaAllocateMemoryForBuffer", ExactSpelling = true)]
        public static extern VkResult AllocateMemoryForBuffer([NativeTypeName("VmaAllocator _Nonnull")] VmaAllocator allocator, [NativeTypeName("VkBuffer _Nonnull")] VkBuffer buffer, [NativeTypeName("const VmaAllocationCreateInfo * _Nonnull")] VmaAllocationCreateInfo* pCreateInfo, [NativeTypeName("VmaAllocation  _Nullable * _Nonnull")] VmaAllocation* pAllocation, [NativeTypeName("VmaAllocationInfo * _Nullable")] VmaAllocationInfo* pAllocationInfo);

        [DllImport("vma", EntryPoint = "vmaAllocateMemoryForImage", ExactSpelling = true)]
        public static extern VkResult AllocateMemoryForImage([NativeTypeName("VmaAllocator _Nonnull")] VmaAllocator allocator, [NativeTypeName("VkImage _Nonnull")] VkImage image, [NativeTypeName("const VmaAllocationCreateInfo * _Nonnull")] VmaAllocationCreateInfo* pCreateInfo, [NativeTypeName("VmaAllocation  _Nullable * _Nonnull")] VmaAllocation* pAllocation, [NativeTypeName("VmaAllocationInfo * _Nullable")] VmaAllocationInfo* pAllocationInfo);

        [DllImport("vma", EntryPoint = "vmaFreeMemory", ExactSpelling = true)]
        public static extern void FreeMemory([NativeTypeName("VmaAllocator _Nonnull")] VmaAllocator allocator, [NativeTypeName("VmaAllocation _Nullable")] VmaAllocation allocation);

        [DllImport("vma", EntryPoint = "vmaFreeMemoryPages", ExactSpelling = true)]
        public static extern void FreeMemoryPages([NativeTypeName("VmaAllocator _Nonnull")] VmaAllocator allocator, [NativeTypeName("size_t")] nuint allocationCount, [NativeTypeName("VmaAllocation  _Nullable const * _Nonnull")] VmaAllocation* pAllocations);

        [DllImport("vma", EntryPoint = "vmaGetAllocationInfo", ExactSpelling = true)]
        public static extern void GetAllocationInfo([NativeTypeName("VmaAllocator _Nonnull")] VmaAllocator allocator, [NativeTypeName("VmaAllocation _Nonnull")] VmaAllocation allocation, [NativeTypeName("VmaAllocationInfo * _Nonnull")] VmaAllocationInfo* pAllocationInfo);

        [DllImport("vma", EntryPoint = "vmaGetAllocationInfo2", ExactSpelling = true)]
        public static extern void GetAllocationInfo2([NativeTypeName("VmaAllocator _Nonnull")] VmaAllocator allocator, [NativeTypeName("VmaAllocation _Nonnull")] VmaAllocation allocation, [NativeTypeName("VmaAllocationInfo2 * _Nonnull")] VmaAllocationInfo2* pAllocationInfo);

        [DllImport("vma", EntryPoint = "vmaSetAllocationUserData", ExactSpelling = true)]
        public static extern void SetAllocationUserData([NativeTypeName("VmaAllocator _Nonnull")] VmaAllocator allocator, [NativeTypeName("VmaAllocation _Nonnull")] VmaAllocation allocation, [NativeTypeName("void * _Nullable")] void* pUserData);

        [DllImport("vma", EntryPoint = "vmaSetAllocationName", ExactSpelling = true)]
        public static extern void SetAllocationName([NativeTypeName("VmaAllocator _Nonnull")] VmaAllocator allocator, [NativeTypeName("VmaAllocation _Nonnull")] VmaAllocation allocation, [NativeTypeName("const char * _Nullable")] byte* pName);

        [DllImport("vma", EntryPoint = "vmaGetAllocationMemoryProperties", ExactSpelling = true)]
        public static extern void GetAllocationMemoryProperties([NativeTypeName("VmaAllocator _Nonnull")] VmaAllocator allocator, [NativeTypeName("VmaAllocation _Nonnull")] VmaAllocation allocation, [NativeTypeName("VkMemoryPropertyFlags * _Nonnull")] uint* pFlags);

        [DllImport("vma", EntryPoint = "vmaMapMemory", ExactSpelling = true)]
        public static extern VkResult MapMemory([NativeTypeName("VmaAllocator _Nonnull")] VmaAllocator allocator, [NativeTypeName("VmaAllocation _Nonnull")] VmaAllocation allocation, [NativeTypeName("void * _Nullable * _Nonnull")] void** ppData);

        [DllImport("vma", EntryPoint = "vmaUnmapMemory", ExactSpelling = true)]
        public static extern void UnmapMemory([NativeTypeName("VmaAllocator _Nonnull")] VmaAllocator allocator, [NativeTypeName("VmaAllocation _Nonnull")] VmaAllocation allocation);

        [DllImport("vma", EntryPoint = "vmaFlushAllocation", ExactSpelling = true)]
        public static extern VkResult FlushAllocation([NativeTypeName("VmaAllocator _Nonnull")] VmaAllocator allocator, [NativeTypeName("VmaAllocation _Nonnull")] VmaAllocation allocation, [NativeTypeName("VkDeviceSize")] ulong offset, [NativeTypeName("VkDeviceSize")] ulong size);

        [DllImport("vma", EntryPoint = "vmaInvalidateAllocation", ExactSpelling = true)]
        public static extern VkResult InvalidateAllocation([NativeTypeName("VmaAllocator _Nonnull")] VmaAllocator allocator, [NativeTypeName("VmaAllocation _Nonnull")] VmaAllocation allocation, [NativeTypeName("VkDeviceSize")] ulong offset, [NativeTypeName("VkDeviceSize")] ulong size);

        [DllImport("vma", EntryPoint = "vmaFlushAllocations", ExactSpelling = true)]
        public static extern VkResult FlushAllocations([NativeTypeName("VmaAllocator _Nonnull")] VmaAllocator allocator, [NativeTypeName("uint32_t")] uint allocationCount, [NativeTypeName("VmaAllocation  _Nonnull const * _Nullable")] VmaAllocation* allocations, [NativeTypeName("const VkDeviceSize * _Nullable")] ulong* offsets, [NativeTypeName("const VkDeviceSize * _Nullable")] ulong* sizes);

        [DllImport("vma", EntryPoint = "vmaInvalidateAllocations", ExactSpelling = true)]
        public static extern VkResult InvalidateAllocations([NativeTypeName("VmaAllocator _Nonnull")] VmaAllocator allocator, [NativeTypeName("uint32_t")] uint allocationCount, [NativeTypeName("VmaAllocation  _Nonnull const * _Nullable")] VmaAllocation* allocations, [NativeTypeName("const VkDeviceSize * _Nullable")] ulong* offsets, [NativeTypeName("const VkDeviceSize * _Nullable")] ulong* sizes);

        [DllImport("vma", EntryPoint = "vmaCopyMemoryToAllocation", ExactSpelling = true)]
        public static extern VkResult CopyMemoryToAllocation([NativeTypeName("VmaAllocator _Nonnull")] VmaAllocator allocator, [NativeTypeName("const void * _Nonnull")] void* pSrcHostPointer, [NativeTypeName("VmaAllocation _Nonnull")] VmaAllocation dstAllocation, [NativeTypeName("VkDeviceSize")] ulong dstAllocationLocalOffset, [NativeTypeName("VkDeviceSize")] ulong size);

        [DllImport("vma", EntryPoint = "vmaCopyAllocationToMemory", ExactSpelling = true)]
        public static extern VkResult CopyAllocationToMemory([NativeTypeName("VmaAllocator _Nonnull")] VmaAllocator allocator, [NativeTypeName("VmaAllocation _Nonnull")] VmaAllocation srcAllocation, [NativeTypeName("VkDeviceSize")] ulong srcAllocationLocalOffset, [NativeTypeName("void * _Nonnull")] void* pDstHostPointer, [NativeTypeName("VkDeviceSize")] ulong size);

        [DllImport("vma", EntryPoint = "vmaCheckCorruption", ExactSpelling = true)]
        public static extern VkResult CheckCorruption([NativeTypeName("VmaAllocator _Nonnull")] VmaAllocator allocator, [NativeTypeName("uint32_t")] uint memoryTypeBits);

        [DllImport("vma", EntryPoint = "vmaBeginDefragmentation", ExactSpelling = true)]
        public static extern VkResult BeginDefragmentation([NativeTypeName("VmaAllocator _Nonnull")] VmaAllocator allocator, [NativeTypeName("const VmaDefragmentationInfo * _Nonnull")] VmaDefragmentationInfo* pInfo, [NativeTypeName("VmaDefragmentationContext  _Nullable * _Nonnull")] VmaDefragmentationContext* pContext);

        [DllImport("vma", EntryPoint = "vmaEndDefragmentation", ExactSpelling = true)]
        public static extern void EndDefragmentation([NativeTypeName("VmaAllocator _Nonnull")] VmaAllocator allocator, [NativeTypeName("VmaDefragmentationContext _Nonnull")] VmaDefragmentationContext context, [NativeTypeName("VmaDefragmentationStats * _Nullable")] VmaDefragmentationStats* pStats);

        [DllImport("vma", EntryPoint = "vmaBeginDefragmentationPass", ExactSpelling = true)]
        public static extern VkResult BeginDefragmentationPass([NativeTypeName("VmaAllocator _Nonnull")] VmaAllocator allocator, [NativeTypeName("VmaDefragmentationContext _Nonnull")] VmaDefragmentationContext context, [NativeTypeName("VmaDefragmentationPassMoveInfo * _Nonnull")] VmaDefragmentationPassMoveInfo* pPassInfo);

        [DllImport("vma", EntryPoint = "vmaEndDefragmentationPass", ExactSpelling = true)]
        public static extern VkResult EndDefragmentationPass([NativeTypeName("VmaAllocator _Nonnull")] VmaAllocator allocator, [NativeTypeName("VmaDefragmentationContext _Nonnull")] VmaDefragmentationContext context, [NativeTypeName("VmaDefragmentationPassMoveInfo * _Nonnull")] VmaDefragmentationPassMoveInfo* pPassInfo);

        [DllImport("vma", EntryPoint = "vmaBindBufferMemory", ExactSpelling = true)]
        public static extern VkResult BindBufferMemory([NativeTypeName("VmaAllocator _Nonnull")] VmaAllocator allocator, [NativeTypeName("VmaAllocation _Nonnull")] VmaAllocation allocation, [NativeTypeName("VkBuffer _Nonnull")] VkBuffer buffer);

        [DllImport("vma", EntryPoint = "vmaBindBufferMemory2", ExactSpelling = true)]
        public static extern VkResult BindBufferMemory2([NativeTypeName("VmaAllocator _Nonnull")] VmaAllocator allocator, [NativeTypeName("VmaAllocation _Nonnull")] VmaAllocation allocation, [NativeTypeName("VkDeviceSize")] ulong allocationLocalOffset, [NativeTypeName("VkBuffer _Nonnull")] VkBuffer buffer, [NativeTypeName("const void * _Nullable")] void* pNext);

        [DllImport("vma", EntryPoint = "vmaBindImageMemory", ExactSpelling = true)]
        public static extern VkResult BindImageMemory([NativeTypeName("VmaAllocator _Nonnull")] VmaAllocator allocator, [NativeTypeName("VmaAllocation _Nonnull")] VmaAllocation allocation, [NativeTypeName("VkImage _Nonnull")] VkImage image);

        [DllImport("vma", EntryPoint = "vmaBindImageMemory2", ExactSpelling = true)]
        public static extern VkResult BindImageMemory2([NativeTypeName("VmaAllocator _Nonnull")] VmaAllocator allocator, [NativeTypeName("VmaAllocation _Nonnull")] VmaAllocation allocation, [NativeTypeName("VkDeviceSize")] ulong allocationLocalOffset, [NativeTypeName("VkImage _Nonnull")] VkImage image, [NativeTypeName("const void * _Nullable")] void* pNext);

        [DllImport("vma", EntryPoint = "vmaCreateBuffer", ExactSpelling = true)]
        public static extern VkResult CreateBuffer([NativeTypeName("VmaAllocator _Nonnull")] VmaAllocator allocator, [NativeTypeName("const VkBufferCreateInfo * _Nonnull")] VkBufferCreateInfo* pBufferCreateInfo, [NativeTypeName("const VmaAllocationCreateInfo * _Nonnull")] VmaAllocationCreateInfo* pAllocationCreateInfo, [NativeTypeName("VkBuffer  _Nullable * _Nonnull")] VkBuffer* pBuffer, [NativeTypeName("VmaAllocation  _Nullable * _Nonnull")] VmaAllocation* pAllocation, [NativeTypeName("VmaAllocationInfo * _Nullable")] VmaAllocationInfo* pAllocationInfo);

        [DllImport("vma", EntryPoint = "vmaCreateBufferWithAlignment", ExactSpelling = true)]
        public static extern VkResult CreateBufferWithAlignment([NativeTypeName("VmaAllocator _Nonnull")] VmaAllocator allocator, [NativeTypeName("const VkBufferCreateInfo * _Nonnull")] VkBufferCreateInfo* pBufferCreateInfo, [NativeTypeName("const VmaAllocationCreateInfo * _Nonnull")] VmaAllocationCreateInfo* pAllocationCreateInfo, [NativeTypeName("VkDeviceSize")] ulong minAlignment, [NativeTypeName("VkBuffer  _Nullable * _Nonnull")] VkBuffer* pBuffer, [NativeTypeName("VmaAllocation  _Nullable * _Nonnull")] VmaAllocation* pAllocation, [NativeTypeName("VmaAllocationInfo * _Nullable")] VmaAllocationInfo* pAllocationInfo);

        [DllImport("vma", EntryPoint = "vmaCreateDedicatedBuffer", ExactSpelling = true)]
        public static extern VkResult CreateDedicatedBuffer([NativeTypeName("VmaAllocator _Nonnull")] VmaAllocator allocator, [NativeTypeName("const VkBufferCreateInfo * _Nonnull")] VkBufferCreateInfo* pBufferCreateInfo, [NativeTypeName("const VmaAllocationCreateInfo * _Nonnull")] VmaAllocationCreateInfo* pAllocationCreateInfo, [NativeTypeName("void * _Nullable")] void* pMemoryAllocateNext, [NativeTypeName("VkBuffer  _Nullable * _Nonnull")] VkBuffer* pBuffer, [NativeTypeName("VmaAllocation  _Nullable * _Nonnull")] VmaAllocation* pAllocation, [NativeTypeName("VmaAllocationInfo * _Nullable")] VmaAllocationInfo* pAllocationInfo);

        [DllImport("vma", EntryPoint = "vmaCreateAliasingBuffer", ExactSpelling = true)]
        public static extern VkResult CreateAliasingBuffer([NativeTypeName("VmaAllocator _Nonnull")] VmaAllocator allocator, [NativeTypeName("VmaAllocation _Nonnull")] VmaAllocation allocation, [NativeTypeName("const VkBufferCreateInfo * _Nonnull")] VkBufferCreateInfo* pBufferCreateInfo, [NativeTypeName("VkBuffer  _Nullable * _Nonnull")] VkBuffer* pBuffer);

        [DllImport("vma", EntryPoint = "vmaCreateAliasingBuffer2", ExactSpelling = true)]
        public static extern VkResult CreateAliasingBuffer2([NativeTypeName("VmaAllocator _Nonnull")] VmaAllocator allocator, [NativeTypeName("VmaAllocation _Nonnull")] VmaAllocation allocation, [NativeTypeName("VkDeviceSize")] ulong allocationLocalOffset, [NativeTypeName("const VkBufferCreateInfo * _Nonnull")] VkBufferCreateInfo* pBufferCreateInfo, [NativeTypeName("VkBuffer  _Nullable * _Nonnull")] VkBuffer* pBuffer);

        [DllImport("vma", EntryPoint = "vmaDestroyBuffer", ExactSpelling = true)]
        public static extern void DestroyBuffer([NativeTypeName("VmaAllocator _Nonnull")] VmaAllocator allocator, [NativeTypeName("VkBuffer _Nullable")] VkBuffer buffer, [NativeTypeName("VmaAllocation _Nullable")] VmaAllocation allocation);

        [DllImport("vma", EntryPoint = "vmaCreateImage", ExactSpelling = true)]
        public static extern VkResult CreateImage([NativeTypeName("VmaAllocator _Nonnull")] VmaAllocator allocator, [NativeTypeName("const VkImageCreateInfo * _Nonnull")] VkImageCreateInfo* pImageCreateInfo, [NativeTypeName("const VmaAllocationCreateInfo * _Nonnull")] VmaAllocationCreateInfo* pAllocationCreateInfo, [NativeTypeName("VkImage  _Nullable * _Nonnull")] VkImage* pImage, [NativeTypeName("VmaAllocation  _Nullable * _Nonnull")] VmaAllocation* pAllocation, [NativeTypeName("VmaAllocationInfo * _Nullable")] VmaAllocationInfo* pAllocationInfo);

        [DllImport("vma", EntryPoint = "vmaCreateDedicatedImage", ExactSpelling = true)]
        public static extern VkResult CreateDedicatedImage([NativeTypeName("VmaAllocator _Nonnull")] VmaAllocator allocator, [NativeTypeName("const VkImageCreateInfo * _Nonnull")] VkImageCreateInfo* pImageCreateInfo, [NativeTypeName("const VmaAllocationCreateInfo * _Nonnull")] VmaAllocationCreateInfo* pAllocationCreateInfo, [NativeTypeName("void * _Nullable")] void* pMemoryAllocateNext, [NativeTypeName("VkImage  _Nullable * _Nonnull")] VkImage* pImage, [NativeTypeName("VmaAllocation  _Nullable * _Nonnull")] VmaAllocation* pAllocation, [NativeTypeName("VmaAllocationInfo * _Nullable")] VmaAllocationInfo* pAllocationInfo);

        [DllImport("vma", EntryPoint = "vmaCreateAliasingImage", ExactSpelling = true)]
        public static extern VkResult CreateAliasingImage([NativeTypeName("VmaAllocator _Nonnull")] VmaAllocator allocator, [NativeTypeName("VmaAllocation _Nonnull")] VmaAllocation allocation, [NativeTypeName("const VkImageCreateInfo * _Nonnull")] VkImageCreateInfo* pImageCreateInfo, [NativeTypeName("VkImage  _Nullable * _Nonnull")] VkImage* pImage);

        [DllImport("vma", EntryPoint = "vmaCreateAliasingImage2", ExactSpelling = true)]
        public static extern VkResult CreateAliasingImage2([NativeTypeName("VmaAllocator _Nonnull")] VmaAllocator allocator, [NativeTypeName("VmaAllocation _Nonnull")] VmaAllocation allocation, [NativeTypeName("VkDeviceSize")] ulong allocationLocalOffset, [NativeTypeName("const VkImageCreateInfo * _Nonnull")] VkImageCreateInfo* pImageCreateInfo, [NativeTypeName("VkImage  _Nullable * _Nonnull")] VkImage* pImage);

        [DllImport("vma", EntryPoint = "vmaDestroyImage", ExactSpelling = true)]
        public static extern void DestroyImage([NativeTypeName("VmaAllocator _Nonnull")] VmaAllocator allocator, [NativeTypeName("VkImage _Nullable")] VkImage image, [NativeTypeName("VmaAllocation _Nullable")] VmaAllocation allocation);

        [DllImport("vma", EntryPoint = "vmaCreateVirtualBlock", ExactSpelling = true)]
        public static extern VkResult CreateVirtualBlock([NativeTypeName("const VmaVirtualBlockCreateInfo * _Nonnull")] VmaVirtualBlockCreateInfo* pCreateInfo, [NativeTypeName("VmaVirtualBlock  _Nullable * _Nonnull")] VmaVirtualBlock* pVirtualBlock);

        [DllImport("vma", EntryPoint = "vmaDestroyVirtualBlock", ExactSpelling = true)]
        public static extern void DestroyVirtualBlock([NativeTypeName("VmaVirtualBlock _Nullable")] VmaVirtualBlock virtualBlock);

        [DllImport("vma", EntryPoint = "vmaIsVirtualBlockEmpty", ExactSpelling = true)]
        [return: NativeTypeName("VkBool32")]
        public static extern uint IsVirtualBlockEmpty([NativeTypeName("VmaVirtualBlock _Nonnull")] VmaVirtualBlock virtualBlock);

        [DllImport("vma", EntryPoint = "vmaGetVirtualAllocationInfo", ExactSpelling = true)]
        public static extern void GetVirtualAllocationInfo([NativeTypeName("VmaVirtualBlock _Nonnull")] VmaVirtualBlock virtualBlock, [NativeTypeName("VmaVirtualAllocation _Nonnull")] VmaVirtualAllocation allocation, [NativeTypeName("VmaVirtualAllocationInfo * _Nonnull")] VmaVirtualAllocationInfo* pVirtualAllocInfo);

        [DllImport("vma", EntryPoint = "vmaVirtualAllocate", ExactSpelling = true)]
        public static extern VkResult VirtualAllocate([NativeTypeName("VmaVirtualBlock _Nonnull")] VmaVirtualBlock virtualBlock, [NativeTypeName("const VmaVirtualAllocationCreateInfo * _Nonnull")] VmaVirtualAllocationCreateInfo* pCreateInfo, [NativeTypeName("VmaVirtualAllocation  _Nullable * _Nonnull")] VmaVirtualAllocation* pAllocation, [NativeTypeName("VkDeviceSize * _Nullable")] ulong* pOffset);

        [DllImport("vma", EntryPoint = "vmaVirtualFree", ExactSpelling = true)]
        public static extern void VirtualFree([NativeTypeName("VmaVirtualBlock _Nonnull")] VmaVirtualBlock virtualBlock, [NativeTypeName("VmaVirtualAllocation _Nullable")] VmaVirtualAllocation allocation);

        [DllImport("vma", EntryPoint = "vmaClearVirtualBlock", ExactSpelling = true)]
        public static extern void ClearVirtualBlock([NativeTypeName("VmaVirtualBlock _Nonnull")] VmaVirtualBlock virtualBlock);

        [DllImport("vma", EntryPoint = "vmaSetVirtualAllocationUserData", ExactSpelling = true)]
        public static extern void SetVirtualAllocationUserData([NativeTypeName("VmaVirtualBlock _Nonnull")] VmaVirtualBlock virtualBlock, [NativeTypeName("VmaVirtualAllocation _Nonnull")] VmaVirtualAllocation allocation, [NativeTypeName("void * _Nullable")] void* pUserData);

        [DllImport("vma", EntryPoint = "vmaGetVirtualBlockStatistics", ExactSpelling = true)]
        public static extern void GetVirtualBlockStatistics([NativeTypeName("VmaVirtualBlock _Nonnull")] VmaVirtualBlock virtualBlock, [NativeTypeName("VmaStatistics * _Nonnull")] VmaStatistics* pStats);

        [DllImport("vma", EntryPoint = "vmaCalculateVirtualBlockStatistics", ExactSpelling = true)]
        public static extern void CalculateVirtualBlockStatistics([NativeTypeName("VmaVirtualBlock _Nonnull")] VmaVirtualBlock virtualBlock, [NativeTypeName("VmaDetailedStatistics * _Nonnull")] VmaDetailedStatistics* pStats);

        [DllImport("vma", EntryPoint = "vmaBuildVirtualBlockStatsString", ExactSpelling = true)]
        public static extern void BuildVirtualBlockStatsString([NativeTypeName("VmaVirtualBlock _Nonnull")] VmaVirtualBlock virtualBlock, [NativeTypeName("char * _Nullable * _Nonnull")] byte** ppStatsString, [NativeTypeName("VkBool32")] uint detailedMap);

        [DllImport("vma", EntryPoint = "vmaFreeVirtualBlockStatsString", ExactSpelling = true)]
        public static extern void FreeVirtualBlockStatsString([NativeTypeName("VmaVirtualBlock _Nonnull")] VmaVirtualBlock virtualBlock, [NativeTypeName("char * _Nullable")] byte* pStatsString);

        [DllImport("vma", EntryPoint = "vmaBuildStatsString", ExactSpelling = true)]
        public static extern void BuildStatsString([NativeTypeName("VmaAllocator _Nonnull")] VmaAllocator allocator, [NativeTypeName("char * _Nullable * _Nonnull")] byte** ppStatsString, [NativeTypeName("VkBool32")] uint detailedMap);

        [DllImport("vma", EntryPoint = "vmaFreeStatsString", ExactSpelling = true)]
        public static extern void FreeStatsString([NativeTypeName("VmaAllocator _Nonnull")] VmaAllocator allocator, [NativeTypeName("char * _Nullable")] byte* pStatsString);
    }
}
