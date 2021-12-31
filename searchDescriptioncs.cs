
// step for search in Bst
//1.Start from the root.
//2.Compare the searching element with root, if less than root, then recurse for left, else recurse for right. 
//3. If the element to search is found anywhere, return true, else return false. 
//we want to search for the number,
//what we’ll do is we’ll start at the root,
//and then we will compare the value to be searched with the value of the root
//if it’s equal we are done with the search if it’s lesser we know that we need to go to the left subtree
//because in a binary search tree all the elements in the left subtree are lesser
//and all the elements in the right subtree are greater.
//Searching an element in the binary search tree is basically this traversal
//in which at each step we will go either towards left or right and
//hence in at each step we discard one of the sub-trees.
//If the tree is balanced, we call a tree balanced
//if for all nodes the difference between the heights of left and right subtrees is not greater than one,
//we will start with a search space of ‘n’nodes and when we will discard one of the sub-trees
//we will discard ‘n/2’ nodes so our search space will be reduced to ‘n/2’
//and then in the next step we will reduce the search space to ‘n/4’
//and we will go on reducing like this till we find the element or till our search space is reduced to only one node.
//The search here is also a binary search and that’s why the name binary search tree.
