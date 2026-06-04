class Solution {
public:
    int carFleet(int target, vector<int>& position, vector<int>& speed) {
        int n = position.size();
        vector<pair<int,int>> cars;
        for (int i = 0; i < n; i++) {
            cars.push_back({position[i], speed[i]});
        }

        sort(cars.begin(), cars.end()); // sort theo position tăng dần

        stack<double> st;
        for (int i = 0; i < n; i++) {
            double t = (double)(target - cars[i].first) / cars[i].second;

            while (!st.empty() && t >= st.top()) {
                st.pop();
            }
            st.push(t);
        }

        return st.size();
    }
};
