/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode() : val(0), next(nullptr) {}
 *     ListNode(int x) : val(x), next(nullptr) {}
 *     ListNode(int x, ListNode *next) : val(x), next(next) {}
 * };
 */

class Solution {
public:
    void merge(ListNode* list1, ListNode* list2)
    {
        if (list1 == nullptr || list2 == nullptr) return;
        if (list1->val > list2->val) 
        { 
            merge(list2, list1);
        }
        else {
            if (list1->next != nullptr && list2->val < list1->next->val)
            {
                ListNode* tmp = list2->next;
                list2->next = list1->next;
                list1->next = list2;
                list2 = tmp;
            }
            else if (list1->next == nullptr) {
                list1->next = list2;
                return;
            }
            else {
                list1 = list1->next;
            }
            merge(list1, list2);
        }
    }

    ListNode* mergeTwoLists(ListNode* list1, ListNode* list2) {
        if (list1 == nullptr) return list2;
        if (list2 == nullptr) return list1;
        ListNode* head = list1->val <= list2->val ? list1 : list2;    
        merge(list1, list2);
        return head;
    }
};
