# Bubble Sort
def bubble_sort(arr):
    n = len(arr)
    # Traverse through all array elements
    for i in range(n):
        # Last i elements are already in place
        for j in range(0, n - i - 1):
            # Swap if the element found is greater than the next element
            if arr[j] > arr[j+1]:
                arr[j], arr[j+1] = arr[j+1], arr[j]
        # (Optional) pass statement does nothing here

arr = [5, 3, 8, 4, 2]
bubble_sort(arr)
print(arr)

# Selection Sort
def selection_sort(arr):
    n = len(arr)
    # Traverse through all array elements
    for i in range(n):
        min_index = i  # Assume the current position holds the minimum
        # Find the minimum element in remaining unsorted array
        for j in range(i+1, n):
            if arr[j] < arr[min_index]:
                min_index = j
        # Swap the found minimum element with the first element of unsorted part
        arr[i], arr[min_index] = arr[min_index], arr[i]

arr2 = [5, 3, 8, 4, 2]
selection_sort(arr2)
print(arr2)

# Insertion Sort
def insertion_sort(arr):
    n = len(arr)
    # Traverse from 1 to n-1
    for i in range(1, n):
        key = arr[i]  # Current element to be inserted
        j = i - 1
        # Move elements of arr[0..i-1], that are greater than key, to one position ahead
        while j >= 0 and arr[j] > key:
            arr[j + 1] = arr[j]
            j -= 1
        # Place key after the element just smaller than it
        arr[j+1] = key

arr3 = [5, 3, 8, 4, 2]
insertion_sort(arr3)
print(arr3)  # Expected: [2, 3, 4, 5, 8]

# Merge Sort (Fusion Sort)
def merge_sort(arr):
    # Only proceed if array has more than one element
    if len(arr) > 1:
        mid = len(arr) // 2  # Find the middle point
        left = arr[:mid]     # Divide the array elements into 2 halves
        right = arr[mid:]

        # Recursively sort the first half
        merge_sort(left)
        # Recursively sort the second half
        merge_sort(right)

        i = j = k = 0  # Initialize pointers for left, right, and merged array

        # Copy data to temp arrays left[] and right[]
        while i < len(left) and j < len(right):
            if left[i] < right[j]:
                arr[k] = left[i]
                i += 1
            else:
                arr[k] = right[j]
                j += 1
            k += 1

        # Check if any element was left in left[]
        while i < len(left):
            arr[k] = left[i]
            i += 1
            k += 1

        # Check if any element was left in right[]
        while j < len(right):
            arr[k] = right[j]
            j += 1
            k += 1

arr4 = [5, 3, 8, 4, 2]
merge_sort(arr4)
print(arr4)  # Expected: [2, 3, 4, 5, 8]

def partition(arr, low, high):
    pivot = arr[high]
    i = low - 1
    
    for j in range(low, high):
        if arr[j] <= pivot:
            i += 1
            arr[i], arr[j] = arr[j], arr[i]
        arr[i+1], arr[high] = arr[high], arr[i+1]
        return i + 1
    
def quick_sort(arr, low, high):
    if low < high:
        pi = partition(arr, low, high)
        quick_sort(arr, low, pi - 1)
        quick_sort(arr, pi + 1, high)
        
arr5 = [5, 3, 8, 4, 2]
quick_sort(arr5, 0, len(arr5) - 1)
print(arr5)  # Expected: [2, 3, 4, 5, 8]
