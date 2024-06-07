#include <stdio.h>
#include <stdlib.h>

#define MAX_CHILDREN 10  //the maximum number of children for each node is 10

typedef struct Node {
    int key;
    struct Node* children[MAX_CHILDREN];
    int childCount;
} Node;

Node* createNode(int key) {
    Node* newNode = (Node*)malloc(sizeof(Node));
    newNode->key = key;
    newNode->childCount = 0;
    for (int i = 0; i < MAX_CHILDREN; i++) {
        newNode->children[i] = NULL;
    }
    return newNode;
}

typedef struct NaryTree {
    Node* root;
} NaryTree;

NaryTree* createTree() {
    NaryTree* newTree = (NaryTree*)malloc(sizeof(NaryTree));
    newTree->root = NULL;
    return newTree;
}

//function for inserting a node
void insert(Node* parent, int key) {
    if (parent->childCount < MAX_CHILDREN) {
        parent->children[parent->childCount] = createNode(key);
        parent->childCount++;
    } else {
        printf("Cannot insert: maximum children reached for this node.\n");
    }
}
//function for searching a node
Node* search(Node* node, int key) {
    if (node == NULL) return NULL;
    if (node->key == key) return node;

    for (int i = 0; i < node->childCount; i++) {
        Node* result = search(node->children[i], key);
        if (result != NULL) return result;
    }
    return NULL;
}
//the function for delete node 
void deleteNode(Node* parent, int key) {
    if (parent == NULL) return;

    for (int i = 0; i < parent->childCount; i++) {
        if (parent->children[i]->key == key) {
            free(parent->children[i]);
            for (int j = i; j < parent->childCount - 1; j++) {
                parent->children[j] = parent->children[j + 1];
            }
            parent->childCount--;
            return;
        }
        deleteNode(parent->children[i], key);
    }
}
//The preorder Traversal function
void preorderTraversal(Node* node) {
    if (node == NULL) return;

    printf("%c ", node->key);
    for (int i = 0; i < node->childCount; i++) {
        preorderTraversal(node->children[i]);
    }
}

// Apply in main function
int main() {
    NaryTree* tree = createTree();
    tree->root = createNode('A');  //Creating the root node
    
    //Inserting children nodes to the root 
    insert(tree->root, 'B');
    insert(tree->root, 'C');
    insert(tree->root, 'D');
    
    //Inserting children nodes for the B node 
    Node* node2 = search(tree->root, 'B');
    if (node2) {
        insert(node2, 'E');
        insert(node2, 'F');
    }
    
    //Inserting children nodes for the C node
    Node* node3 = search(tree->root, 'C');
    if (node3) {
        insert(node3, 'G');
        insert(node3, 'H');
        insert(node3, 'I');
    }
    //Inserting a node child for D node 
    Node* node4 = search(tree->root, 'D');
    if (node4) {
        insert(node4, 'J');
    }
    
    //inserting a child to J node
    Node* node5 = search(node4, 'J');
    if (node5) {
        insert(node5, 'K');
    }

    printf("Pre-order traversal of the tree:\n");
    preorderTraversal(tree->root);
    printf("\n");

    printf("Delete node with key 'K':\n");
    deleteNode(tree->root, 'K');
    preorderTraversal(tree->root);
    printf("\n");

    return 0;
}